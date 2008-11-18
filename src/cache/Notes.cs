using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a graph batches pair into a bucket.</summary>
        public static long GradeGraphBatches(long target, long target2)
        {
            if (target2 > (target2 & 3))
            {
                return 1;
            }
            else
            {
                if (6.9 > (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((target2 + target2) >= (target >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target / 5) == (target2 / 8))
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

        /// <summary>Check that every layout order entry stays within the limit.</summary>
        public static bool ValidateLayoutOrderRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long step, long limit)
        {
            if ((step + limit) < (limit - 99))
            {
                return 5;
            }
            else
            {
                if ((19.0 * 0.5) < (double)step)
                {
                    return 8;
                }
                else
                {
                    if (!((limit & 7) <= step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8.47 * 6.19) > (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((9.65 + 8.8) <= (double)hits)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
