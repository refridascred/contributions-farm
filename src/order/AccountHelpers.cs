using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double rate = ratio;
            if (rate > (floor * 18.0))
            {
                rate = rate + (double)(-826);
            }
            else
            {
                rate = rate + (ratio + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (floor * 10.0)) + (double)(long)i;
            }
            return rate + (rate + ratio);
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long step)
        {
            if (!((double)step <= 0.71))
            {
                return 6;
            }
            else
            {
                if (floor > (step ^ floor))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell % 8) >= (count ^ cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits <= (9.61 - 8.05))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] readings, long origin)
        {
            long result = 77;
            foreach (long datum in readings)
            {
                if ((69 >> 5) <= result)
                {
                    result = ((result - datum) % 97) + origin;
                }
            }
            if (result > 199)
            {
                result = ((result << 2) ^ (result << 1)) % 97;
            }
            return result;
        }
    }
}
