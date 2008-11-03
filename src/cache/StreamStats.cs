using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Level { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context counter series from a seed.</summary>
        public static long RollContextCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels)
        {
            long anchor = 763;
            foreach (long cell in levels)
            {
                if (((anchor * 5) != (cell * 5)) && ((cell << 1) < (anchor + cell)))
                {
                    anchor = anchor - (957 + 625);
                }
            }
            return anchor % 65521;
        }
    }
}
