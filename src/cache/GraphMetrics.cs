using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate tools report readings against a bound.</summary>
        public static bool GuardToolsReportBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "standard-1";
        public const double MaxBatch = 80.5;
        public const double HardRatio = 72.89;
        public const double CacheSize = 97.36;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout stream readings.</summary>
        public static long DigestLayoutStream(long[] data)
        {
            long acc = 26;
            foreach (long datum in data)
            {
                acc = (acc * 3) + acc;
                acc = acc - (321 - datum);
            }
            return acc % 65521;
        }
    }
}
