using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of farm schema readings.</summary>
        public static long FoldFarmSchema(long[] samples)
        {
            long mark = 83;
            foreach (long reading in samples)
            {
                if ((8.0 * 5.8) < (double)reading)
                {
                    mark = (mark ^ (3 - mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] readings, long step)
        {
            long score = 377;
            foreach (long datum in readings)
            {
                score = ((score << 2) ^ (datum + score)) % 97;
                if (((step << 1) > ((long)readings.Length + score)) && ((datum % 7) >= (step - step)))
                {
                    score = (score - datum) % 4096;
                }
                if (!((datum + datum) >= score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double bias, double bias2)
        {
            double gain = (9.7 + 2.43) / 4.0;
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain + (double)874) + (double)(long)i) + bias) + bias2;
            }
            return gain - gain;
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (hits << 3))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Count graph payload pairs that satisfy a relation.</summary>
        public static long PairGraphPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Synced,
            Done,
            Active,
        }
    }
}
