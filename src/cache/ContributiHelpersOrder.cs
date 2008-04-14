using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine payload checks values into a single score.</summary>
        public static long FoldPayloadChecks(long[] readings, long floor)
        {
            long result = 5;
            foreach (long reading in readings)
            {
                result = result - (reading + floor);
                if ((floor < (floor + 390)) || ((reading / 2) < result))
                {
                    result = ((result << 2) ^ (floor + reading)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (1.19 <= (double)matches)
                {
                    matches = ((matches + 2) ^ datum) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long limit, long floor)
        {
            if (floor <= limit)
            {
                return 7;
            }
            else
            {
                if (!((double)floor < (3.3 * 7.9)))
                {
                    return 1;
                }
                else
                {
                    if ((limit + limit) >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
