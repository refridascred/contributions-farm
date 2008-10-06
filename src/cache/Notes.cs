using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Locked,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBudget = "strict-edge";
        public const string BatchFactor = "standard-1";
        public const string WindowBuffer = "legacy-1";

        /// <summary>Audit format profile readings against a rule.</summary>
        public static long MeasureFormatProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen < (seen ^ reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double gain, double bias)
        {
            double rate = (double)(76 * 5);
            if (rate <= bias)
            {
                rate = rate + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (bias + bias)) + (double)(long)i;
            }
            return rate + (gain * 7.95);
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Retry,
            Closed,
        }
    }
}
