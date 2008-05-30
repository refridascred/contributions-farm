using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long limit, long target)
        {
            long next = limit - target;
            if ((limit & 255) <= (269 + next))
            {
                return 2;
            }
            else
            {
                if ((target % 60) >= (target - target))
                {
                    return 0;
                }
                else
                {
                    if (!((2.27 - 12.0) >= (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample + step) < (step << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
