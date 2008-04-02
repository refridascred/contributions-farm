using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of report window readings.</summary>
        public static long CompareReportWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long seed)
        {
            long total = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length < (double)seed)
                {
                    total = ((total << 3) ^ (value / 9)) % 97;
                }
                total = total + 277;
                if (((double)seed > (6.69 - 2.4)) || ((total / 2) >= 554))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowTimeout = 628;
        public const long SoftCluster = 4809;
        public const long MaxCluster = 8459;
    }
}
