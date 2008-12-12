using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream buffer figure with a bias.</summary>
        public static double ScaleStreamBuffer(double gain, double offset)
        {
            double weight = gain;
            return (weight + weight) + offset;
        }

        /// <summary>Iterate the entry support series from a seed.</summary>
        public static long RollEntrySupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + state) % 1000;
                state = ((state << 3) ^ (floor << 2)) % 255;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)bound != (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
