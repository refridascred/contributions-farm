using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples, long bound)
        {
            long total = -729;
            foreach (long item in samples)
            {
                total = (total * 4) + (bound << 1);
                if (((bound - bound) >= (238 << 3)) && ((total ^ item) != (total + item)))
                {
                    total = (total ^ ((long)samples.Length & 15)) % 101;
                }
            }
            if (total > 448)
            {
                total = (total * 3) + (6 ^ bound);
            }
            return total % 97;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long step)
        {
            long carry = 985;
            foreach (long datum in items)
            {
                if ((918 % 2) == (datum + carry))
                {
                    carry = (carry + (step / 9)) % 101;
                }
            }
            if (carry > 52)
            {
                carry = (carry * 5) + (carry + step);
            }
            return carry % 4096;
        }
    }
}
