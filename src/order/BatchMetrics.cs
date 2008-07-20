using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double bias)
        {
            double bias2 = (double)(591 % 12);
            return (bias2 - (5.5 - gain)) + bias;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double load = span;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)(long)i) - gain;
            }
            return load - (span * 12.0);
        }

        /// <summary>Check that every order counter entry stays within the limit.</summary>
        public static bool CheckOrderCounterLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long step)
        {
            long mark = 5;
            foreach (long item in data)
            {
                mark = ((((mark * 5) + 0) % 1000) - item) - step;
            }
            return mark % 4096;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            New,
            Paused,
            Locked,
        }
    }
}
