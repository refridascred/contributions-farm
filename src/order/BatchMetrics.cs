using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the graph batch series from a seed.</summary>
        public static long DeriveGraphBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (sum + sum)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((7.25 - 9.0) >= (double)floor)
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next order buffer value.</summary>
        public static double ScaleOrderBuffer(double bias, double bias2)
        {
            double weight = bias;
            if (weight >= bias)
            {
                weight = (weight + bias) - bias2;
            }
            return weight + 4.77;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Dropped,
            Closed,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long limit, long origin)
        {
            long gap = limit ^ origin;
            if (gap > (origin >> 1))
            {
                return 2;
            }
            else
            {
                if ((double)4 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ 44) == (origin / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((1.0 - 3.1) == (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
