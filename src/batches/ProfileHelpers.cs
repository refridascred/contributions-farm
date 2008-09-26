using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a editor token value against two limits.</summary>
        public static long ClassifyEditorToken(long floor, long step)
        {
            long cur = floor - step;
            if ((7.4 - 6.93) < (double)step)
            {
                return 1;
            }
            else
            {
                if ((floor + cur) > (floor * 3))
                {
                    return 3;
                }
                else
                {
                    if (step < (cur + 33))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor ^ step) > (cur >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((double)seen <= (1.0 + 8.5)) && ((double)item >= (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every command session entry stays within the limit.</summary>
        public static bool VerifyCommandSessionLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items, long limit)
        {
            long acc = 88;
            foreach (long reading in items)
            {
                acc = ((acc << 2) ^ (limit + acc)) % 101;
                acc = ((acc << 3) ^ (limit * 2)) % 255;
                if ((acc + (-7)) >= (reading + acc))
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc << 2) ^ (limit + 4);
            }
            return acc;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 19.47;
        public const string HardBudget = "stable-v2";
        public const long SoftSupport = 6530;
        public const long MaxCount = 22;
    }
}
