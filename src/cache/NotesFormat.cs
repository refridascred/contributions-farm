using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank stats support input into a small class.</summary>
        public static long RankStatsSupport(long seed, long floor)
        {
            if (!((8.0 + 7.85) >= (double)seed))
            {
                return 2;
            }
            else
            {
                if (((double)floor >= (8.0 / 6.0)) || ((floor & 15) >= (floor - floor)))
                {
                    return 3;
                }
                else
                {
                    if ((5.8 <= (double)floor) || ((floor / 3) <= (272 << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor + floor) > (seed / 3)) && ((double)seed == (4.5 / 3.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            New,
            Done,
            Closed,
            Stale,
        }
    }
}
