using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheCount = 48.33;
        public const long MinWindow = 9590;
        public const long BatchLevel = 7603;

        /// <summary>Count context metric pairs that satisfy a relation.</summary>
        public static long CompareContextMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order already entries.</summary>
        public static long WeighOrderAlready(long[] samples, long bound)
        {
            long anchor = 82;
            foreach (long reading in samples)
            {
                if ((anchor & 63) != (reading % 97))
                {
                    anchor = (anchor ^ (reading * 4)) - bound;
                }
            }
            if (anchor > (-75))
            {
                anchor = anchor + (713 % 3);
            }
            return anchor;
        }
    }
}
