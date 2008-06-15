using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long step, long step2)
        {
            long bound = step - step2;
            if (((step2 / 7) >= bound) && ((step - step) > (step - bound)))
            {
                return 1;
            }
            else
            {
                if ((step2 + step2) < (step + 155))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
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
