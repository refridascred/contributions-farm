using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long anchor = 416;
            foreach (long cell in values)
            {
                anchor = anchor - (anchor & 63);
                anchor = (anchor + anchor) % 101;
                if (cell <= (anchor >> 5))
                {
                    anchor = (anchor << 2) ^ cell;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a support graph counter forward.</summary>
        public static long StepSupportGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if (bound < ((-316) << 2))
                {
                    anchor = ((anchor * 4) + bound) % 255;
                }
                anchor = (anchor + (bound & 127)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
