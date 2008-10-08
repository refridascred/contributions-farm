using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = score ^ (0 + (long)i);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
