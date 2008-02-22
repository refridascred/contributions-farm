using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i & 255) >= ((long)i % 64)))
                {
                    mix = mix ^ mix;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-272) & 3) == (sample ^ 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleSize = 52.36;
        public const long StepCount = 3537;
        public const double BatchOrder = 37.97;
    }
}
