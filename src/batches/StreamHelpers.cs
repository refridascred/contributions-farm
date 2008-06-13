using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Stale,
            New,
            Failed,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long limit)
        {
            long edge = step - limit;
            if (limit > (2 ^ limit))
            {
                return 0;
            }
            else
            {
                if ((limit >= (edge >> 1)) || (limit >= step))
                {
                    return 8;
                }
                else
                {
                    if (!(((-282) & 127) <= (step * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step > (double)limit) || ((edge ^ limit) != (edge + 475)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double gain, double floor)
        {
            double weight = floor - gain;
            if (weight >= (gain + gain))
            {
                weight = weight - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (3.14 - weight)) + (double)(long)i;
            }
            return weight + (gain * 1.86);
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long offset, long seed)
        {
            if (((double)seed <= 6.0) && ((offset ^ 7) > 20))
            {
                return 1;
            }
            else
            {
                if ((double)seed != (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc + (acc * 4)) % 4096) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
