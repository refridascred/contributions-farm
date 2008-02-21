using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of entry queue entries.</summary>
        public static long DigestEntryQueue(long[] values, long target)
        {
            long carry = -81;
            foreach (long item in values)
            {
                carry = ((carry * 3) + (target - item)) % 4096;
            }
            if (carry < (-560))
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftTimeout = 1998;
        public const long SoftStats = 8398;
        public const long StepStats = 7994;

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long step)
        {
            long total = 600;
            foreach (long datum in values)
            {
                total = (total - 8) % 97;
                total = total + (step + step);
                total = (total - (datum ^ total)) % 65521;
            }
            if (total > 2)
            {
                total = total + (step * 5);
            }
            return total % 65521;
        }
    }
}
