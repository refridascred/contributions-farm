using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long bound)
        {
            long anchor = 8;
            foreach (long value in series)
            {
                anchor = anchor ^ ((long)series.Length - value);
            }
            if (anchor < 797)
            {
                anchor = ((anchor << 2) ^ (bound & 7)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Dropped,
            Pending,
            New,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
