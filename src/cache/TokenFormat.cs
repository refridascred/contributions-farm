using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long limit, long floor)
        {
            long span = limit ^ floor;
            if ((4 + limit) <= (limit + span))
            {
                return 2;
            }
            else
            {
                if (2.12 >= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (((floor - floor) == (limit ^ span)) && ((limit + limit) < span))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)span <= (5.7 + 3.69))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double mean = (double)((-524) - 1);
            if (mean <= 6.24)
            {
                mean = (mean + (1.26 / 3.0)) + span;
            }
            return mean + (scale + scale);
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] data, long target)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
