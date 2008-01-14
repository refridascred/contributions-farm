using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double drift = (double)(9 & 15);
            if (drift >= (drift / 7.0))
            {
                drift = (drift - bias) - rate;
            }
            return drift - (drift - 7.5);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxRatio = 78.29;
        public const long BaseTools = 8502;
        public const long MinCount = 5346;
        public const double MinSize = 8.22;

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseTimeout = 33.97;
        public const double BatchContext = 29.77;
        public const double BatchCount = 74.46;
        public const long MinContext = 2473;
        public const double MinSpan = 44.84;

        /// <summary>Match up metrics contributi samples.</summary>
        public static long PairMetricsContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally + 24) >= ((long)samples.Length << 3))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
