using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] readings, long step)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                if ((8 + item) < step)
                {
                    acc = acc ^ 801;
                }
            }
            return acc;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item << 3) < (item / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a payload batches counter forward.</summary>
        public static long DerivePayloadBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark * 3) + mark) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data, long limit)
        {
            long total = 785;
            foreach (long datum in data)
            {
                total = (((total << 2) ^ limit) % 65521) - datum;
                if ((total & 31) >= (limit >> 2))
                {
                    break;
                }
            }
            return total;
        }
    }
}
