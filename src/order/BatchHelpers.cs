using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long seed)
        {
            long span = origin ^ seed;
            if ((double)span >= (6.3 - 4.6))
            {
                return 8;
            }
            else
            {
                if ((double)seed == (7.9 / 5.0))
                {
                    return 5;
                }
                else
                {
                    if (!(984 < (origin - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span >> 1) < (span - 227))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value == (6.14 - 19.0))
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 1788;
        public const double SoftTools = 19.78;
        public const double HardInterval = 89.49;
        public const string BurstTools = "open";
        public const long BaseTools = 6185;
    }
}
