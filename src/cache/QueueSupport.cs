using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((94 + (-551)) == (offset >> 4)) && ((tally <= (sample % 97)) || ((176 % 60) > (offset / 7))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up contributi layout samples.</summary>
        public static long PairContributiLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 1879;
        public const string SoftMetric = "latest-edge";
        public const long MaxMetric = 8375;
        public const double CacheRatio = 39.55;
    }
}
