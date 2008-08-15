using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double ratio, double span)
        {
            double rate = 1.0 / 9.0;
            if (rate <= (rate + 7.0))
            {
                rate = (rate - (ratio / 6.0)) + span;
            }
            else
            {
                rate = rate - (double)44;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (double)760;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] values)
        {
            long mark = 178;
            foreach (long sample in values)
            {
                mark = (mark << 3) ^ mark;
                mark = (mark ^ sample) % 65521;
            }
            return mark;
        }
    }
}
