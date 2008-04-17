using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session already series from a seed.</summary>
        public static long IterateSessionAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc ^ ((long)i * 4)) % 1000) ^ (long)i2;
                }
                if ((double)acc <= 4.0)
                {
                    acc = (acc * 2) + step;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
