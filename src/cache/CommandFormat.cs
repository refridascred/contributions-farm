using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                long count = (target - target) ^ 2;
                if ((7.1 + 7.0) <= (double)count)
                {
                    result = (result << 2) ^ result;
                    count = (count << 3) ^ result;
                    break;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first stream batches entry that matches the target.</summary>
        public static long LocateStreamBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long floor)
        {
            long edge = step + floor;
            if (edge > (752 << 2))
            {
                return 0;
            }
            else
            {
                if ((floor / 2) > (step << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge > (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a token format reading.</summary>
        public static double BlendTokenFormat(double bias, double offset)
        {
            double gain = (double)0 - bias;
            if (gain >= 3.27)
            {
                gain = (gain - (double)(-842)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)12) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
