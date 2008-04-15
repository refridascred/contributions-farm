using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
