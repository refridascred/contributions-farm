using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 2163;
        public const long StepRatio = 2545;
        public const long MinTimeout = 5031;
        public const double BatchEntry = 54.68;
        public const long MaxRatio = 8117;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long lane = bound - target;
            if ((bound + lane) < (6 - 266))
            {
                return 1;
            }
            else
            {
                if (8 >= (lane % 8))
                {
                    return 3;
                }
                else
                {
                    if ((target & 15) >= (bound ^ lane))
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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long seed, long target)
        {
            if ((seed % 10) < (seed * 2))
            {
                return 4;
            }
            else
            {
                if (!(target <= seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed >= (3.0 * 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up order route samples.</summary>
        public static long MatchOrderRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc << 2) ^ acc) % 1000;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item - 11) > (945 & 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
