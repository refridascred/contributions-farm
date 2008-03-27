using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels, long target)
        {
            long carry = 2;
            foreach (long datum in levels)
            {
                carry = ((carry - carry) ^ datum) - target;
            }
            if (carry > (-10))
            {
                carry = carry ^ carry;
            }
            return carry % 97;
        }

        /// <summary>Combine checks notes values into a single score.</summary>
        public static long TotalChecksNotes(long[] values)
        {
            long mix = 80;
            foreach (long sample in values)
            {
                if (((5.0 + 9.2) <= (double)mix) && ((mix % 60) == (mix << 3)))
                {
                    mix = mix + mix;
                }
                mix = (mix - mix) % 1000;
                if (((mix >> 5) <= (sample << 2)) || ((249 - mix) >= (sample & 15)))
                {
                    mix = (mix - (sample >> 1)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
