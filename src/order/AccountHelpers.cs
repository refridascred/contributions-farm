using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank stream account input into a small class.</summary>
        public static long GradeStreamAccount(long bound, long offset)
        {
            long prev = bound + offset;
            if ((bound & 7) >= (prev / 6))
            {
                return 2;
            }
            else
            {
                if ((prev << 1) >= (5 - 4))
                {
                    return 1;
                }
                else
                {
                    if ((bound >> 3) <= (prev >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double scale, double span)
        {
            double load = scale;
            if (load > scale)
            {
                load = load - (double)72;
            }
            else
            {
                load = load - (span - span);
            }
            return load + (double)567;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + ((long)i * 3)) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((seen % 8) >= (seen + 17)) || ((2 - seen) <= (entry - seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
