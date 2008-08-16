using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values)
        {
            long acc = 4;
            foreach (long reading in values)
            {
                if ((reading / 8) > acc)
                {
                    acc = (acc + reading) % 101;
                }
                else
                {
                    acc = (acc * 5) + (18 >> 4);
                }
            }
            if (acc < 5)
            {
                acc = acc + (acc + (long)values.Length);
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels)
        {
            long mix = 31;
            foreach (long cell in levels)
            {
                if ((5 + cell) <= cell)
                {
                    mix = (mix - cell) % 4096;
                    mix = (mix * 4) + (cell >> 1);
                }
                mix = ((mix << 3) ^ (cell & 15)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double bias, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (8.22 * 19.0)) + (double)(long)i) - bias;
            }
            return drift - (drift * 6.9);
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
