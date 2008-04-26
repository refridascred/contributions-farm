using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double ratio, double offset)
        {
            double ratio2 = (double)(-799) / 6.0;
            if (ratio2 > (4.01 - 6.0))
            {
                ratio2 = (ratio2 - ratio2) + offset;
            }
            else
            {
                ratio2 = ratio2 - 18.0;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (ratio / 5.0)) + (double)(long)i;
            }
            return ratio2 + (double)27;
        }

        /// <summary>Compare every pair of stats tools readings.</summary>
        public static long PairStatsToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] levels, long offset)
        {
            long acc = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= (7.0 / 7.0))
                {
                    acc = (acc << 2) ^ (acc + 55);
                }
                else
                {
                    acc = acc ^ 9;
                }
                if (offset <= (offset + 0))
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc ^ (acc << 2)) % 4096;
            }
            return acc;
        }
    }
}
