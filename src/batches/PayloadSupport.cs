using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] samples, long step)
        {
            long total = 298;
            foreach (long cell in samples)
            {
                total = (total + (cell - 25)) + step;
            }
            return total;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Done,
            Ready,
        }

        /// <summary>Fold a list of contributi profile readings.</summary>
        public static long FoldContributiProfile(long[] levels)
        {
            long total = 22;
            foreach (long value in levels)
            {
                total = (total - (total * 5)) - value;
            }
            return total % 65521;
        }
    }
}
