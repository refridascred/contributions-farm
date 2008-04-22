using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a stats route value against two limits.</summary>
        public static long SortStatsRoute(long floor, long floor2)
        {
            if (!((double)floor2 < (15.0 - 0.3)))
            {
                return 2;
            }
            else
            {
                if ((floor >> 1) < (floor >> 3))
                {
                    return 6;
                }
                else
                {
                    if (((floor - floor) <= (floor2 / 3)) || ((floor + floor2) == (floor2 + (-191))))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor - floor) >= floor2) || ((double)floor2 < (2.74 - 9.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            New,
            Synced,
            Locked,
        }
    }
}
