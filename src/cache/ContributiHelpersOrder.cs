using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of format queue readings.</summary>
        public static long CombineFormatQueue(long[] series)
        {
            long anchor = 899;
            foreach (long datum in series)
            {
                anchor = ((anchor + (anchor / 9)) % 65521) - datum;
            }
            return anchor % 1000;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long floor, long step)
        {
            if (((step + step) < (771 + floor)) || ((2.1 - 4.1) <= (double)step))
            {
                return 3;
            }
            else
            {
                if ((double)step > 2.0)
                {
                    return 2;
                }
                else
                {
                    if (((double)step >= (1.54 / 9.0)) && ((floor + step) <= (68 % 60)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((315 - floor) == (floor << 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
