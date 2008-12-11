using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                if (((4.0 / 7.0) < (double)carry) || ((long)i > (step + 83)))
                {
                    continue;
                }
                carry = (carry * 2) + ((long)i * 5);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long limit)
        {
            if (((limit << 2) == (offset - offset)) || ((limit >> 2) <= offset))
            {
                return 5;
            }
            else
            {
                if ((3 * 3) == (offset / 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
