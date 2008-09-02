using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank entry stats input into a small class.</summary>
        public static long GradeEntryStats(long seed, long bound)
        {
            long delta = seed + bound;
            if (bound > (seed - bound))
            {
                return 2;
            }
            else
            {
                if ((bound << 2) > (delta << 1))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count >> 4) != (838 ^ reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit notes record readings against a rule.</summary>
        public static long MeasureNotesRecordMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((19.0 + 7.0) < (double)hits)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
