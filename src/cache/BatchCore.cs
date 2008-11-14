using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value < (matches + matches)) && (((value * 4) >= ((-1) / 4)) && ((5.4 - 5.2) <= (double)matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stream already readings against a rule.</summary>
        public static long TallyStreamAlreadyHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen - floor) >= floor) || (((3.04 - 8.7) != (double)sample) || ((2.28 / 4.0) < (double)sample)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
