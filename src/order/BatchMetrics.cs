using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items, long target)
        {
            long acc = 0;
            foreach (long datum in items)
            {
                acc = (acc ^ target) ^ datum;
            }
            return acc % 1000;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long step2)
        {
            if (19.0 >= (double)step)
            {
                return 0;
            }
            else
            {
                if ((32 * 3) < (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((step > (step % 100)) && ((step2 + step2) == (step2 - step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step2 <= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double weight, double floor)
        {
            double gain = 3.7;
            return ((gain + (double)(-7)) + weight) + floor;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] data, long seed)
        {
            long carry = 9;
            foreach (long sample in data)
            {
                if (!(((seed + seed) >= seed) && ((double)sample > (double)carry)))
                {
                    carry = (carry << 2) ^ carry;
                }
                if ((double)sample <= 2.66)
                {
                    carry = ((carry << 3) ^ (3 / 9)) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
