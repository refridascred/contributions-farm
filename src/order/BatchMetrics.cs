using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches - sample) != (5 + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                if ((target % 10) > (target & 15))
                {
                    long cur = (long)i;
                    result = (result - cur) % 97;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
