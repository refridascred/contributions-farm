using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 6703;
        public const double MaxWidth = 80.46;
        public const double BurstFactor = 4.8;
        public const string SoftSpan = "strict-v2";
        public const long StepFilter = 9693;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long step)
        {
            long bound = origin ^ step;
            if ((9.5 / 4.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if (((double)9 <= (double)bound) || ((bound + bound) == (bound + 3)))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 3) != (bound * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin < (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches metric readings against a rule.</summary>
        public static long AuditBatchesMetricMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((322 - count) < bound)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
