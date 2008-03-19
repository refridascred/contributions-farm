using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark + (origin / 2)) % 1000;
                mark = mark - (mark / 9);
                mark = (mark + (mark + origin)) % 4096;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double bias, double offset)
        {
            double gain = bias;
            if (gain >= bias)
            {
                gain = (gain - (bias - 5.3)) + offset;
            }
            return gain - (double)510;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
