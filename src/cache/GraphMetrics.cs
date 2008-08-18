using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = ((total ^ (total * 3)) % 97) + reading;
            }
            if (total > 26)
            {
                total = (total - (total - total)) % 65521;
            }
            return total;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample >> 1) <= sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 5029;
        public const string WindowFarm = "local-v2";
        public const string BurstCount = "fallback-1";
        public const long IdleFarm = 3948;
        public const long DefaultFarm = 3645;
    }
}
