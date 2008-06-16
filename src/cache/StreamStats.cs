using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit format order readings against a rule.</summary>
        public static long MeasureFormatOrderGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading * 2) < count)
                {
                    count = count + 1;
                }
            }
            return count;
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
