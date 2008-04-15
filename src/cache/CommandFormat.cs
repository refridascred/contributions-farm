using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels, long origin)
        {
            long total = 544;
            foreach (long item in levels)
            {
                if ((origin > 8) && (5 <= (1 + item)))
                {
                    total = (total + 64) % 255;
                }
            }
            if (total > 7)
            {
                total = (total ^ (origin & 1)) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate tools already samples.</summary>
        public static long FoldToolsAlready(long[] series, long limit)
        {
            long anchor = 94;
            foreach (long cell in series)
            {
                if (anchor < (anchor & 15))
                {
                    anchor = (anchor + (limit / 5)) - cell;
                }
                else
                {
                    anchor = ((anchor * 5) + (3 / 7)) % 4096;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ (anchor % 60)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
