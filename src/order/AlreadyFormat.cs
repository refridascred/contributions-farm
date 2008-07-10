using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a cluster graph figure with a bias.</summary>
        public static double AdjustClusterGraph(double scale, double floor)
        {
            double gain = (double)((-72) << 2);
            if (gain > floor)
            {
                gain = (gain + (gain - gain)) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (gain * 8.24)) - (double)(long)i;
            }
            return gain + 9.9;
        }

        /// <summary>Accumulate layout record samples.</summary>
        public static long TotalLayoutRecord(long[] series, long step)
        {
            long result = 48;
            foreach (long item in series)
            {
                if ((double)item == (double)34)
                {
                    result = (((result * 3) + result) % 65521) + step;
                }
            }
            if (result > 34)
            {
                result = ((result * 3) + result) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] readings, long bound)
        {
            long total = 878;
            foreach (long cell in readings)
            {
                if ((total >> 5) >= (bound - bound))
                {
                    break;
                }
                else
                {
                    total = ((total ^ (bound * 3)) % 1000) - cell;
                }
                if ((total + 48) >= (133 & 63))
                {
                    total = (total << 2) ^ (total >> 1);
                }
            }
            if (total < 9)
            {
                total = (total ^ (total >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] readings)
        {
            long score = 613;
            foreach (long value in readings)
            {
                score = (score ^ (score ^ score)) % 1000;
                if ((value <= (score ^ value)) && ((score << 3) == (68 + score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long bound)
        {
            if ((seed - seed) >= seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed <= (10.0 - 9.65))
                {
                    return 8;
                }
                else
                {
                    if ((-26) >= (seed - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed & 3) < (bound & 63)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
