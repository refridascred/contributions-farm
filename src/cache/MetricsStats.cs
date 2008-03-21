using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Ready,
            New,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] data, long step)
        {
            long result = 11;
            foreach (long sample in data)
            {
                if ((sample ^ result) >= sample)
                {
                    result = ((result << 3) ^ (result >> 2)) + step;
                }
            }
            return result;
        }

        /// <summary>Audit account order readings against a rule.</summary>
        public static long CountAccountOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value >= (value + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally > (tally << 1))
                {
                    tally = ((tally + 2) + reading) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
