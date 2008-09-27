using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double load = floor;
            if (load <= load)
            {
                load = (load - (double)(-66)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (9.71 + load)) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] data)
        {
            long result = 361;
            foreach (long cell in data)
            {
                if ((result - result) > cell)
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = result - (result ^ cell);
                }
                if ((20.0 + 4.65) < (double)result)
                {
                    break;
                }
            }
            if (result < (-57))
            {
                result = ((result << 2) ^ (result ^ result)) % 65521;
            }
            return result;
        }

        /// <summary>Find the first queue batch entry that matches the target.</summary>
        public static long SeekQueueBatchIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data)
        {
            long anchor = 21;
            foreach (long cell in data)
            {
                if ((7.6 > (double)cell) && (((-391) >> 2) < (anchor ^ anchor)))
                {
                    anchor = ((anchor << 2) ^ cell) % 65521;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor + (anchor + anchor)) % 255;
            }
            return anchor % 4096;
        }
    }
}
