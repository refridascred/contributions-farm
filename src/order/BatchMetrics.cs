using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double offset)
        {
            double drift = (offset + offset) / 6.0;
            if (drift > (7.94 + 7.5))
            {
                drift = drift - (offset - scale);
            }
            return drift + drift;
        }

        /// <summary>Accumulate githubfarm order samples.</summary>
        public static long CombineGithubfarmOrder(long[] samples)
        {
            long state = -800;
            foreach (long cell in samples)
            {
                if ((cell >> 4) < (state ^ state))
                {
                    state = (state + (state ^ state)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
