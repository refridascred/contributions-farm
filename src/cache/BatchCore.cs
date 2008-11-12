using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 544;
        public const long BaseSpan = 1659;
        public const long WindowRecord = 3581;
        public const long DefaultInterval = 4946;
        public const double RetryRecord = 60.96;

        /// <summary>Blend two editor stream measurements.</summary>
        public static double SmoothEditorStream(double weight, double span)
        {
            double scale = (weight / 6.0) / 4.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (weight + 9.01)) - (double)(long)i) - span;
            }
            return scale + (double)1;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (rate * 2.91);
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
