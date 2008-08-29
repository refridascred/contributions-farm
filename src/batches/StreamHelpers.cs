using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels)
        {
            long total = 415;
            foreach (long value in levels)
            {
                if ((7.7 / 7.0) < (double)value)
                {
                    total = ((total << 3) ^ (38 - 6)) % 65521;
                }
                else
                {
                    total = ((total * 4) + value) % 65521;
                }
                if ((double)total < 4.92)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine metric cluster values into a single score.</summary>
        public static long FoldMetricCluster(long[] levels)
        {
            long anchor = 3;
            foreach (long entry in levels)
            {
                if (anchor >= (entry - anchor))
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Locate a entry token reading by value.</summary>
        public static long SeekEntryTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches % 12) <= (25 + matches))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }
    }
}
