using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
                anchor = anchor ^ (anchor - anchor);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Project the next queue metrics value.</summary>
        public static double ProjectQueueMetrics(double ratio, double bias)
        {
            double drift = 0.21;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + ratio) - (double)(long)i) - bias;
            }
            return drift - 13.0;
        }

        /// <summary>Digest a series of profile support entries.</summary>
        public static long CombineProfileSupport(long[] series, long bound)
        {
            long total = 717;
            foreach (long datum in series)
            {
                if (((25 >> 3) >= datum) && ((total * 5) != (datum ^ datum)))
                {
                    total = ((total ^ (total & 1)) % 101) - bound;
                }
            }
            if (total < 190)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }
    }
}
