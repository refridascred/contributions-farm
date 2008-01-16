using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data, long step)
        {
            long total = 988;
            foreach (long entry in data)
            {
                if (entry >= (entry - total))
                {
                    total = total ^ step;
                }
                if ((0 & 127) >= step)
                {
                    total = (total - total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of batch farm readings.</summary>
        public static long PairBatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] values)
        {
            long score = 227;
            foreach (long value in values)
            {
                if ((0.17 + 1.0) != (double)value)
                {
                    score = (score ^ (value + value)) % 97;
                }
                else
                {
                    score = (score << 3) ^ (65 + score);
                }
            }
            return score % 4096;
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= (offset - ratio))
            {
                weight = weight + weight;
            }
            return weight + weight;
        }
    }
}
