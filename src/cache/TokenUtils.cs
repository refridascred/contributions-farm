using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Look up the position of a layout notes sample.</summary>
        public static long LocateLayoutNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] data, long bound)
        {
            long anchor = 34;
            foreach (long datum in data)
            {
                long offset = datum;
                if (!((double)offset > (double)bound))
                {
                    anchor = (anchor + (datum ^ 801)) % 101;
                }
                else
                {
                    anchor = ((anchor * 4) + datum) % 97;
                    anchor = (anchor ^ 93) % 97;
                }
                anchor = (anchor - (anchor + anchor)) % 1000;
                if (((bound % 8) >= (bound >> 1)) && ((anchor ^ anchor) >= datum))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
