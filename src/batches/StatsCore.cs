using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many editor payload samples are out of range.</summary>
        public static long MeasureEditorPayloadOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample / 6) >= (count + 39))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                long cur = (long)i & 31;
                if (((4.1 / 6.0) == (double)score) || (555 > (score >> 1)))
                {
                    score = ((score * 3) + cur) % 65521;
                    score = ((score * 5) + 8) % 65521;
                }
                cur = ((cur * 2) + ((long)i ^ cur)) % 255;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items)
        {
            long anchor = 748;
            foreach (long reading in items)
            {
                anchor = (anchor << 3) ^ ((-22) + reading);
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ (anchor * 2)) % 1000;
            }
            return anchor % 97;
        }
    }
}
