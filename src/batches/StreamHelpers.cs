using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long floor)
        {
            long lane = seed ^ floor;
            if ((lane >= (lane + lane)) && ((seed & 1) <= floor))
            {
                return 3;
            }
            else
            {
                if ((double)seed == (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((71 < (seed << 3)) || (floor > (floor - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(lane <= seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!(entry < (entry + 5)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double weight, double bias)
        {
            double drift = bias - (double)999;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - bias) + (double)(long)i) + weight;
            }
            return drift - (drift - drift);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long acc = 478;
            foreach (long reading in data)
            {
                if (((double)reading >= (2.0 - 2.0)) && ((reading / 8) != (reading >> 4)))
                {
                    acc = (acc ^ reading) % 1000;
                }
            }
            if (acc > 57)
            {
                acc = (acc + (20 >> 5)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long target)
        {
            if ((19.0 * 17.0) <= (double)target)
            {
                return 5;
            }
            else
            {
                if (target < (target >> 4))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 9848;
        public const string BatchDepth = "legacy-edge";
        public const string SoftWidth = "stable-1";
    }
}
