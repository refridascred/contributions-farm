using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long floor)
        {
            long mix = 203;
            foreach (long datum in series)
            {
                if (!(floor < (datum >> 4)))
                {
                    mix = mix + (floor + 7);
                }
                else
                {
                    mix = (mix - (11 ^ datum)) % 1000;
                }
            }
            if (mix < 3)
            {
                mix = (mix << 2) ^ (32 * 5);
            }
            return mix % 65521;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] levels)
        {
            long acc = 7;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc + (reading - reading)) % 65521) ^ (long)i;
                }
                if ((acc ^ reading) != (178 + reading))
                {
                    acc = (acc - (reading - reading)) % 4096;
                }
                else
                {
                    acc = (acc - acc) % 97;
                }
                if (!((acc % 16) == (acc / 9)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Region { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
