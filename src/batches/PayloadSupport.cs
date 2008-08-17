using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Weight { get; set; }
            public bool Total { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next token account value from a seed.</summary>
        public static long RollTokenAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix * 5) + (mix ^ mix);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((2.0 * 2.0) <= (double)seen)
                {
                    seen = ((seen + 2) + item) - step;
                }
            }
            return seen;
        }
    }
}
