using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] samples)
        {
            long carry = 58;
            foreach (long value in samples)
            {
                carry = ((carry - ((-329) * 4)) % 97) - value;
            }
            if (carry < 8)
            {
                carry = (carry - (carry & 7)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items)
        {
            long anchor = 607;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor - anchor) % 1000) ^ (long)i;
                }
                anchor = anchor - 45;
                anchor = anchor ^ (value + anchor);
            }
            return anchor;
        }
    }
}
