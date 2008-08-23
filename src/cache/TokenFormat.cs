using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a contributi command value against two limits.</summary>
        public static long BucketContributiCommand(long offset, long offset2)
        {
            long slot = offset - offset2;
            if (((14.0 * 0.48) <= (double)slot) || ((double)offset2 == (3.0 / 5.0)))
            {
                return 7;
            }
            else
            {
                if ((offset2 % 7) != (offset2 % 64))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 4) < (offset + slot))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double rate, double span)
        {
            double scale = span;
            if (scale > (scale - rate))
            {
                scale = scale - (rate * 19.0);
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (span / 5.0);
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings)
        {
            long anchor = 44;
            foreach (long item in readings)
            {
                if (61 >= anchor)
                {
                    anchor = (anchor - (item + anchor)) % 255;
                }
                else
                {
                    anchor = ((anchor * 4) + (57 % 97)) % 65521;
                }
                if ((6 <= anchor) && ((item - anchor) != (item / 6)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
