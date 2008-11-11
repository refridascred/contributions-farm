using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long step)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                if ((sum * 4) < (sum % 10))
                {
                    sum = (((sum << 2) ^ sample) % 101) + step;
                }
                sum = (sum - (sum << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Closed,
            Active,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings)
        {
            long anchor = 700;
            foreach (long cell in readings)
            {
                if (cell <= anchor)
                {
                    anchor = anchor + cell;
                }
            }
            if (anchor > 211)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
