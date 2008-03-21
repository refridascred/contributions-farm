using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long target)
        {
            long step = origin ^ target;
            if ((target >= step) || ((double)82 != (double)step))
            {
                return 5;
            }
            else
            {
                if ((7.1 - 4.13) == (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((double)step == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate order entry samples.</summary>
        public static long TotalOrderEntry(long[] samples)
        {
            long acc = 394;
            foreach (long value in samples)
            {
                if (!(value >= (value >> 5)))
                {
                    acc = ((acc << 2) ^ 89) % 101;
                    break;
                }
                if (value > (acc ^ 11))
                {
                    acc = (acc * 2) + value;
                }
            }
            if (acc < 5)
            {
                acc = ((acc * 4) + (acc & 127)) % 97;
            }
            return acc;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
