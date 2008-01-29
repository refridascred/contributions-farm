using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] series)
        {
            long anchor = 91;
            foreach (long entry in series)
            {
                if (entry >= anchor)
                {
                    anchor = ((anchor << 2) ^ (anchor >> 2)) % 97;
                }
            }
            if (anchor < 75)
            {
                anchor = (anchor * 5) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if ((double)875 != (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((bound + offset) > (bound ^ 8)))
                {
                    return 0;
                }
                else
                {
                    if (offset > (bound & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.25 + 13.0) == (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - 7.5) + (double)(long)i) - rate;
            }
            return mean + (double)152;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long carry = 470;
            foreach (long datum in levels)
            {
                carry = ((carry * 2) + (carry + datum)) % 255;
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry + datum) % 97) + (long)i;
                }
                if (carry < (73 << 2))
                {
                    carry = (carry ^ (621 + datum)) % 255;
                }
            }
            return carry;
        }
    }
}
