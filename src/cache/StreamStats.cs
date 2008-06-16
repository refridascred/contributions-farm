using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double bias2 = 13.0 - (rate * 5.5);
            if (bias2 <= bias)
            {
                bias2 = bias2 - 4.1;
            }
            else
            {
                bias2 = bias2 + (double)84;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (4.2 - bias2)) + (double)(long)i;
            }
            return bias2 - rate;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long floor, long target)
        {
            long prev = floor - target;
            if ((8 >> 2) > (floor - target))
            {
                return 2;
            }
            else
            {
                if (!(floor > 1))
                {
                    return 0;
                }
                else
                {
                    if (5.58 < (double)prev)
                    {
                        return 3;
                    }
                    else
                    {
                        if (267 <= (floor - 886))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double scale = (double)(73 ^ 63);
            return (scale + span) + bias;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits < (offset - hits))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
