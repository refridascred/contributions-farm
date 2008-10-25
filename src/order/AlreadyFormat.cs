using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Ready,
            New,
            Queued,
            Done,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long limit, long floor)
        {
            if (((limit ^ floor) < limit) || ((floor / 5) <= (floor - limit)))
            {
                return 6;
            }
            else
            {
                if (!((5.7 + 19.0) > (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((floor - limit) <= ((-8) - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (1.11 > (double)floor)
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

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double scale, double bias)
        {
            double mean = scale / 3.0;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - (bias * 5.9);
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series)
        {
            long acc = 83;
            foreach (long datum in series)
            {
                acc = ((acc * 3) + acc) % 65521;
                if (datum <= ((-6) >> 1))
                {
                    acc = (acc - (datum + acc)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc % 7)) % 97;
                }
            }
            if (acc > 26)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples, long bound)
        {
            long score = 146;
            foreach (long datum in samples)
            {
                score = (score ^ (bound >> 5)) + datum;
                if ((bound >> 3) != (727 - 3))
                {
                    score = ((score << 3) ^ (score & 1)) % 4096;
                }
            }
            return score;
        }
    }
}
