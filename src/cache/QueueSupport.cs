using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((floor & 3) < floor)
                {
                    anchor = anchor ^ ((long)i * 5);
                }
                if (!(((long)i * 4) <= 14))
                {
                    anchor = (anchor ^ (long)i) % 65521;
                    anchor = (anchor << 3) ^ (anchor + floor);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
