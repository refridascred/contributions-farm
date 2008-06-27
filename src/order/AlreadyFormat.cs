using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a record order figure with a bias.</summary>
        public static double BlendRecordOrder(double gain, double bias)
        {
            double load = bias;
            if (load > 8.4)
            {
                load = load + gain;
            }
            else
            {
                load = load - (double)345;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (gain + bias);
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long limit, long seed)
        {
            long step = limit - seed;
            if ((step + step) == (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((limit / 4) > step)
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 1) != (step ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed + step) <= limit) || ((step - limit) < (896 >> 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
