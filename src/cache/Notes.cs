using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double offset)
        {
            double scale = (15.0 - offset) * 10.0;
            if (scale < (double)577)
            {
                scale = scale - 4.76;
            }
            else
            {
                scale = scale + (gain + 2.0);
            }
            return scale + scale;
        }

        /// <summary>Fold a list of profile already readings.</summary>
        public static long WeighProfileAlready(long[] items)
        {
            long state = 621;
            foreach (long cell in items)
            {
                if (!(state <= (state - cell)))
                {
                    state = ((state << 2) ^ cell) % 101;
                }
                state = ((state * 4) + (cell - cell)) % 1000;
                state = (state ^ (state % 7)) % 255;
            }
            return state;
        }
    }
}
