using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of counter session entries.</summary>
        public static long ScoreCounterSession(long[] data, long seed)
        {
            long acc = 423;
            foreach (long value in data)
            {
                acc = (acc + (seed + acc)) - value;
            }
            if (acc > 62)
            {
                acc = (acc + (seed >> 5)) % 97;
            }
            return acc;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long floor)
        {
            if ((double)offset == (15.0 * 4.08))
            {
                return 3;
            }
            else
            {
                if ((floor & 31) < (offset % 24))
                {
                    return 1;
                }
                else
                {
                    if ((offset > (offset % 8)) && ((floor & 127) < (offset * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - 8) >= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Retry,
            Idle,
            Closed,
        }
    }
}
