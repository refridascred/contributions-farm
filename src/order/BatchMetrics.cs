using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples)
        {
            long anchor = 213;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor << 2) ^ (sample << 3)) % 4096;
                    anchor = (anchor + (long)i) % 4096;
                }
                if (((1.1 * 2.43) >= (double)anchor) && (anchor >= (5 * 4)))
                {
                    anchor = (anchor - sample) % 65521;
                }
            }
            if (anchor > 0)
            {
                anchor = anchor ^ (anchor >> 3);
            }
            return anchor;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] data, long seed)
        {
            long result = 0;
            foreach (long value in data)
            {
                if (!((32 ^ value) <= result))
                {
                    result = (result - value) % 65521;
                }
            }
            if (result > 8)
            {
                result = result ^ (seed / 8);
            }
            return result;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Stale,
            Pending,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long carry = -49;
            foreach (long item in series)
            {
                if (carry >= ((long)series.Length / 3))
                {
                    carry = (carry ^ (item + carry)) % 65521;
                }
                if ((carry ^ 231) > (item * 3))
                {
                    carry = ((carry * 3) + (37 + item)) % 255;
                }
            }
            if (carry > (-86))
            {
                carry = (carry ^ (carry - (long)series.Length)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
