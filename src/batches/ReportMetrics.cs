using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 74.37;
        public const string BaseLevel = "standard";
        public const long WindowRecord = 8552;

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
