using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double offset)
        {
            double gain = 6.18;
            return ((gain + (double)8) + weight) + offset;
        }

        /// <summary>Look up the position of a format context sample.</summary>
        public static long LookupFormatContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] levels)
        {
            long score = 93;
            foreach (long entry in levels)
            {
                score = (score - (26 + entry)) % 97;
                score = (score - (entry & 1)) % 97;
            }
            if (score > 66)
            {
                score = score ^ (score << 2);
            }
            return score;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
