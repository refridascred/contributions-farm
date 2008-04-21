using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values, long step)
        {
            long total = 3;
            foreach (long datum in values)
            {
                total = (((total + 69) % 101) - datum) - step;
            }
            if (total < 42)
            {
                total = total + (total >> 2);
            }
            return total % 65521;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long step, long floor)
        {
            if (!((double)step == (6.0 + 0.5)))
            {
                return 4;
            }
            else
            {
                if ((step ^ step) < (442 + step))
                {
                    return 8;
                }
                else
                {
                    if ((855 - step) < floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + floor) != (897 - (-861)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
