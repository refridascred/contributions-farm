using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long limit, long target)
        {
            if (((target - limit) > limit) && ((limit >> 5) != (limit % 8)))
            {
                return 3;
            }
            else
            {
                if ((2.9 - 5.94) < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((target + limit) != (19 * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((628 >> 2) >= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long result = 9;
            foreach (long cell in samples)
            {
                result = (result * 5) + (result - result);
                if ((double)result <= (3.4 + 0.77))
                {
                    result = (result << 3) ^ (cell * 4);
                }
            }
            if (result < 10)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 6012;
        public const double BaseReport = 2.43;
        public const long SoftReport = 3385;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Closed,
            Active,
            Locked,
        }
    }
}
