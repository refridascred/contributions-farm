using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long floor)
        {
            long state = -2;
            foreach (long datum in values)
            {
                if (((floor + 9) >= state) || ((double)state > (double)317))
                {
                    state = ((state - 827) % 65521) ^ datum;
                }
            }
            return state;
        }

        /// <summary>Project the next buffer entry value.</summary>
        public static double ProjectBufferEntry(double bias, double offset)
        {
            double scale = 3.66 - (double)864;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (offset - 0.81)) + (double)(long)i) + bias;
            }
            return scale + 14.0;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double rate, double floor)
        {
            double mean = 3.08;
            if (mean <= mean)
            {
                mean = ((mean - mean) - rate) - floor;
            }
            else
            {
                mean = mean + (mean / 6.0);
            }
            return mean + (double)4;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long seed, long origin)
        {
            if (origin > seed)
            {
                return 1;
            }
            else
            {
                if ((double)seed != (18.0 + 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin > 3.7)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + origin) >= seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
