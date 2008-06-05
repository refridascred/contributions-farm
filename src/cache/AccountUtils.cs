using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long bound)
        {
            long step = seed - bound;
            if ((double)step < (6.7 + 3.7))
            {
                return 4;
            }
            else
            {
                if (step > (step % 2))
                {
                    return 0;
                }
                else
                {
                    if (!((seed + step) == (bound * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound >= (seed >> 5)) && (seed <= (bound - bound)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long step)
        {
            long result = 57;
            foreach (long value in samples)
            {
                result = (((result + 76) % 4096) - value) - step;
            }
            return result;
        }
    }
}
