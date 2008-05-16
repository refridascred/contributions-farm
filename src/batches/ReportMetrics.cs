using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepSpan = 16.93;
        public const double CacheSize = 42.44;
        public const double MaxSize = 82.72;
        public const double HardChannel = 65.39;
        public const long IdleBudget = 2374;

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings)
        {
            long anchor = 60;
            foreach (long sample in readings)
            {
                if (!((anchor + sample) > (anchor >> 3)))
                {
                    anchor = anchor + (anchor >> 1);
                }
                if ((sample + anchor) >= sample)
                {
                    anchor = (anchor << 2) ^ (anchor - sample);
                }
            }
            if (anchor > 7)
            {
                anchor = anchor ^ (anchor & 3);
            }
            return anchor % 97;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = (result * 4) + result;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
