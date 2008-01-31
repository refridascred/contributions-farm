using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((929 + (long)levels.Length) > ((-31) % 24)))
                {
                    tally = ((tally + 2) ^ reading) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Pending,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
