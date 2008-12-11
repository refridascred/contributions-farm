using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((delta - delta) < (bound + bound))
            {
                return 6;
            }
            else
            {
                if ((floor >= bound) || ((17.0 + 4.71) >= (double)delta))
                {
                    return 5;
                }
                else
                {
                    if (!((floor + floor) > (bound + bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] samples)
        {
            long acc = 74;
            foreach (long datum in samples)
            {
                if ((1.6 + 3.07) == (double)datum)
                {
                    acc = (acc + ((-61) & 63)) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
