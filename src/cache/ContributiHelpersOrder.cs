using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of editor graph readings.</summary>
        public static long ScoreEditorGraph(long[] items, long origin)
        {
            long total = 599;
            foreach (long value in items)
            {
                if (((total ^ origin) <= origin) && ((total % 97) == (total * 5)))
                {
                    total = total - value;
                    total = (total + (value ^ 8)) % 97;
                }
                if ((double)origin == (1.48 - 1.0))
                {
                    total = ((total << 3) ^ (total + 8)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long origin)
        {
            if ((offset - 4) == (0 / 2))
            {
                return 1;
            }
            else
            {
                if ((1.3 * 6.38) > (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (offset <= (offset % 60))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
