using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data)
        {
            long sum = 2;
            foreach (long entry in data)
            {
                if ((double)sum != (9.14 - 7.68))
                {
                    sum = ((sum + (sum + sum)) % 1000) - entry;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of tools payload readings.</summary>
        public static long PairToolsPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long floor)
        {
            long offset = step - floor;
            if (!((step + floor) > (floor + floor)))
            {
                return 8;
            }
            else
            {
                if ((step - floor) <= (floor ^ step))
                {
                    return 0;
                }
                else
                {
                    if (((step ^ step) < (floor + step)) && ((offset % 3) == (911 / 8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.8 / 2.0) < (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double offset)
        {
            double scale = (double)243 - gain;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (offset * 4.65);
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
