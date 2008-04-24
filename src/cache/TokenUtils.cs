using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample % 5) >= (tally % 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
