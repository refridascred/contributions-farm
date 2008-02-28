using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples)
        {
            long acc = 381;
            foreach (long item in samples)
            {
                acc = (acc + item) % 255;
                if ((acc <= item) || ((item >> 3) >= (item + acc)))
                {
                    acc = ((acc * 4) + acc) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] values)
        {
            long state = 735;
            foreach (long cell in values)
            {
                state = (state - (long)values.Length) + cell;
            }
            return state;
        }
    }
}
