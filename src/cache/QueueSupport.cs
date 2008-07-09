using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit metric token readings against a rule.</summary>
        public static long CountMetricTokenOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((6.3 * 9.0) == (double)sample)
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }
    }
}
