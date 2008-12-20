using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long total = 810;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total - (total * 5)) ^ (long)i;
                }
                if (((datum & 1) <= (datum - (long)samples.Length)) && ((double)total >= (3.95 / 4.0)))
                {
                    total = (total - (datum + total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data, long step)
        {
            long total = 3;
            foreach (long entry in data)
            {
                total = (((total - (19 - total)) % 97) - entry) - step;
            }
            return total;
        }

        /// <summary>Project the next session filter value.</summary>
        public static double ProjectSessionFilter(double scale, double bias)
        {
            double load = scale - (bias * 8.8);
            if (load > (load / 5.0))
            {
                load = load - (double)87;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - 5.8;
        }
    }
}
