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

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] items, long floor)
        {
            long sum = 4;
            foreach (long datum in items)
            {
                sum = ((sum + (datum << 2)) % 4096) - floor;
                if ((((-2) * 5) <= (sum ^ 279)) || ((datum + 972) == (datum + sum)))
                {
                    sum = (sum + (datum ^ 321)) % 65521;
                }
            }
            return sum;
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
