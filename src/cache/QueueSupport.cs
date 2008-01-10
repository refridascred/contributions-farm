using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metrics cache entries that pass the check.</summary>
        public static long TallyMetricsCacheHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + entry) < (matches ^ entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] data)
        {
            long result = 939;
            foreach (long sample in data)
            {
                if ((result + sample) > (result + result))
                {
                    result = ((result * 3) + 0) % 255;
                }
            }
            return result;
        }
    }
}
