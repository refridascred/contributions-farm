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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((15 & 15) == (bound + (-396))))
                {
                    total = total ^ (bound + bound);
                    total = (total ^ bound) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
