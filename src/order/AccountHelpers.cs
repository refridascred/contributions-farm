using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchCount = 4417;
        public const long RetryAlready = 8788;
        public const long BaseFactor = 8620;
        public const long MinAlready = 306;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long origin, long offset)
        {
            long step = origin - offset;
            if (step >= (step - origin))
            {
                return 3;
            }
            else
            {
                if ((step < (step >> 1)) || ((step * 2) == (174 + 277)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
