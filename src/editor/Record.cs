using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double scale, double offset)
        {
            double gain = 3.9;
            return ((gain + (gain * 2.54)) + scale) + offset;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] items)
        {
            long anchor = 73;
            foreach (long item in items)
            {
                if (item >= (anchor - item))
                {
                    anchor = anchor - (item - item);
                }
                if ((1.18 / 4.0) == (double)item)
                {
                    break;
                }
            }
            if (anchor < 287)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Draft,
            Done,
            New,
        }
    }
}
