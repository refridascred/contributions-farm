using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleCount = "alpha-edge";
        public const double DefaultSpan = 14.09;
        public const long StepSize = 1448;
        public const long DefaultFilter = 5240;
        public const double MinFilter = 20.07;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series)
        {
            long state = 287;
            foreach (long cell in series)
            {
                state = (state ^ (cell + state)) % 255;
            }
            return state;
        }
    }
}
