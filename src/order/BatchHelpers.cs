using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((3 + 846) <= (matches >> 5)) || ((sample / 3) != (1 % 64))) && ((matches + sample) > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen + 580) > (item - seen)) || ((390 - 610) != (seen % 10))) || ((0.9 - 6.93) == (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
