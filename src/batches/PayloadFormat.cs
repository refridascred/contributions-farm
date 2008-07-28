using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples)
        {
            long mix = -703;
            foreach (long entry in samples)
            {
                long slot = (20 - mix) + mix;
                if (!(((mix + 8) <= (entry - 561)) || (slot < (entry - entry))))
                {
                    mix = (mix ^ (slot / 6)) % 97;
                }
                mix = (mix + entry) % 97;
            }
            return mix;
        }

        /// <summary>Check that every report editor entry stays within the limit.</summary>
        public static bool ValidateReportEditorRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] items, long bound)
        {
            long carry = 927;
            foreach (long reading in items)
            {
                if ((bound & 1) == (bound >> 5))
                {
                    carry = (carry * 4) + (carry - reading);
                }
            }
            if (carry > 44)
            {
                carry = (carry + 7) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
