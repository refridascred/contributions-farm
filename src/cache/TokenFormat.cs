using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account session entries that pass the check.</summary>
        public static long AuditAccountSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count - datum) >= ((long)samples.Length / 3)) || (((double)count >= (19.0 + 18.0)) || (9 <= (datum & 1))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Score { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long limit, long offset)
        {
            if (((limit + offset) >= (limit << 2)) && ((double)offset >= (double)limit))
            {
                return 5;
            }
            else
            {
                if ((7 + offset) < (offset + offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset + 5) < (252 + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit > (4.0 * 4.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
