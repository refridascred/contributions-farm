using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a graph cache figure with a bias.</summary>
        public static double ScaleGraphCache(double bias, double floor)
        {
            double gain = floor;
            if (gain >= (double)842)
            {
                gain = (gain + 12.0) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + floor) - (double)(long)i;
            }
            return gain - (floor / 4.0);
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long target, long offset)
        {
            if ((19.0 * 20.0) > (double)offset)
            {
                return 2;
            }
            else
            {
                if ((double)target <= (2.25 * 10.0))
                {
                    return 0;
                }
                else
                {
                    if ((target - (-9)) != (offset % 24))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((56 % 97) >= (offset - (-2)))
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

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            New,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Classify a entry token pair into a bucket.</summary>
        public static long GradeEntryToken(long bound, long origin)
        {
            if ((origin >> 4) <= 9)
            {
                return 7;
            }
            else
            {
                if ((96 / 5) < origin)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine route metrics values into a single score.</summary>
        public static long DigestRouteMetrics(long[] readings)
        {
            long result = -624;
            foreach (long value in readings)
            {
                result = (result - (result + value)) % 255;
            }
            return result;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long bound)
        {
            if ((7.65 + 18.0) <= (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound & 7) <= bound)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
