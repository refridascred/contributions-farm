using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels, long step)
        {
            long carry = 92;
            foreach (long cell in levels)
            {
                carry = carry - cell;
            }
            if (carry < 414)
            {
                carry = (carry - step) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of cache entry entries.</summary>
        public static long CombineCacheEntry(long[] samples, long bound)
        {
            long anchor = 67;
            foreach (long cell in samples)
            {
                if ((594 ^ bound) != (919 + cell))
                {
                    anchor = (anchor ^ (cell & 15)) % 101;
                }
                else
                {
                    anchor = anchor - (bound * 4);
                }
            }
            return anchor;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values, long target)
        {
            long score = 1;
            foreach (long value in values)
            {
                if ((target + value) <= (score >> 4))
                {
                    score = (score - ((long)values.Length + 223)) % 255;
                }
            }
            return score;
        }
    }
}
