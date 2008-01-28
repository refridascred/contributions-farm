using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next cluster schema value.</summary>
        public static double BlendClusterSchema(double ratio, double bias)
        {
            double mean = bias * 6.9;
            if (mean <= (double)0)
            {
                mean = (mean - (mean / 9.0)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (double)98;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long seed, long bound)
        {
            if (seed > (seed % 64))
            {
                return 8;
            }
            else
            {
                if (((seed >> 2) < (bound - bound)) && ((double)bound == (double)seed))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound == (6.5 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the notes record series from a seed.</summary>
        public static long DeriveNotesRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - origin) % 65521;
                mark = mark - (mark % 64);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the farm tools series from a seed.</summary>
        public static long DeriveFarmTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
