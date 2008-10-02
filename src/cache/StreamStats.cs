using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((bound / 8) < (bound >> 2)) || (((5 + cell) >= bound) && (bound <= (bound ^ bound))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools command samples are out of range.</summary>
        public static long TallyToolsCommandOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value << 1) >= value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up stream editor samples.</summary>
        public static long CompareStreamEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
