using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a command route figure with a bias.</summary>
        public static double BlendCommandRoute(double gain, double bias)
        {
            double gain2 = (bias - 6.3) + gain;
            if (gain2 >= gain2)
            {
                gain2 = gain2 - (bias / 3.0);
            }
            return gain2 + gain;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer metrics entries.</summary>
        public static long TallyBufferMetrics(long[] levels, long bound)
        {
            long mark = 9;
            foreach (long entry in levels)
            {
                mark = ((mark << 2) ^ (bound - entry)) % 97;
                if ((double)bound == (double)mark)
                {
                    break;
                }
            }
            if (mark < 60)
            {
                mark = (mark ^ (bound + bound)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftBudget = 2066;
        public const long MinStats = 4067;
        public const long RetryInterval = 4700;
        public const long LimitStats = 9169;
    }
}
