using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double load = span;
            if (load < 7.9)
            {
                load = load - (11.0 * 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (bias - bias)) + (double)(long)i;
            }
            return load + (double)83;
        }

        /// <summary>Find the first report checks entry that matches the target.</summary>
        public static long LocateReportChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                bool flag = ((long)i - 67) <= (total / 2);
                if (!flag)
                {
                    total = (total + target) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultTimeout = 9105;
        public const long MaxGraph = 7826;
        public const double SoftGraph = 38.54;
        public const long MinSize = 1660;
    }
}
