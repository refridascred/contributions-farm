using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)target >= (13.0 + 2.9))
                {
                    mark = mark ^ (mark * 5);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long seed, long limit)
        {
            long prev = seed + limit;
            if ((379 ^ prev) != (seed % 5))
            {
                return 2;
            }
            else
            {
                if (204 >= prev)
                {
                    return 8;
                }
                else
                {
                    if (prev > (limit % 10))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Done,
            Retry,
        }
    }
}
