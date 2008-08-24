using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the format schema entries that pass the check.</summary>
        public static long AuditFormatSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits - (-325)) >= (hits - cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cluster counter series from a seed.</summary>
        public static long StepClusterCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((878 & 3) >= floor)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long origin, long target)
        {
            long step = origin ^ target;
            if ((13.0 * 15.0) < (double)origin)
            {
                return 0;
            }
            else
            {
                if ((double)step < (6.0 / 9.0))
                {
                    return 2;
                }
                else
                {
                    if (((origin / 3) >= (origin << 3)) || (((-728) + 2) < target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 7828;
        public const string MaxWidth = "standard-1";
        public const long DefaultFactor = 9085;
        public const double StepSpan = 15.98;
    }
}
