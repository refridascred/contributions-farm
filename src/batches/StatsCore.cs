using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (6.5 <= (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((bound / 6) > (matches / 8))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long target)
        {
            long bound2 = bound - target;
            if (14.0 < (double)target)
            {
                return 6;
            }
            else
            {
                if ((target & 1) <= (target + 1))
                {
                    return 4;
                }
                else
                {
                    if ((4.73 + 2.3) > (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound2 >= target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "open";
        public const double DefaultQueue = 73.69;
        public const double RetryCount = 98.75;
        public const long HardCount = 6656;
        public const long StepFactor = 4319;

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long MeasureRouteCacheGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item / 3) > (item >> 1))
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
