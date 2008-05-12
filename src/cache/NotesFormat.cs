using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample == (double)matches)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long seed, long target)
        {
            long bound = seed + target;
            if (((target % 97) == (bound - target)) || ((target + seed) != (target / 8)))
            {
                return 2;
            }
            else
            {
                if ((bound < (9 ^ target)) || ((target / 6) == (target % 5)))
                {
                    return 6;
                }
                else
                {
                    if ((seed - seed) == (target - target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed >= (seed + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
