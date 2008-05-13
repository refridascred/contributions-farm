using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((7 / 7) > (datum ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }
    }
}
