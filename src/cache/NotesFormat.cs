using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a notes stream pair into a bucket.</summary>
        public static long ClassifyNotesStream(long offset, long target)
        {
            long slot = offset - target;
            if (3.5 >= (double)slot)
            {
                return 0;
            }
            else
            {
                if (slot < (slot / 2))
                {
                    return 2;
                }
                else
                {
                    if ((target + 181) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (slot <= (target & 255))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the token context series from a seed.</summary>
        public static long SeriesTokenContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
