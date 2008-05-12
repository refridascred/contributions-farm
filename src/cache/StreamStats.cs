using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)origin < 1.1)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long offset2)
        {
            long span = offset - offset2;
            if ((offset * 4) >= (span << 3))
            {
                return 7;
            }
            else
            {
                if ((offset + 96) < offset2)
                {
                    return 8;
                }
                else
                {
                    if ((offset - offset2) >= ((-3) & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if (63 <= (offset << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
