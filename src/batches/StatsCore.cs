using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((4.46 - 3.0) >= (double)origin)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Match up session token samples.</summary>
        public static long PairSessionTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit tools cluster readings against a rule.</summary>
        public static long CountToolsClusterGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally ^ limit) >= tally)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((limit << 3) != (reading << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
