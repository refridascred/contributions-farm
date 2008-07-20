using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)score <= (3.65 + 7.31))
                {
                    score = score - (seed - 39);
                    continue;
                }
                score = ((score * 4) + (63 % 2)) % 255;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many batches record samples are out of range.</summary>
        public static long MeasureBatchesRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (7.8 < (double)(long)readings.Length)
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double span)
        {
            double rate = scale;
            return (rate + (rate / 9.0)) + span;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long bound)
        {
            if (!((double)bound <= (10.0 * 0.7)))
            {
                return 4;
            }
            else
            {
                if ((9.0 / 2.0) < (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((offset * 3) != (988 - offset)) || ((offset & 1) > (922 + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset > (12.0 - 0.32))
                        {
                            return 7;
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
