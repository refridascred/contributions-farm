using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 9882;
        public const double IdleFactor = 62.25;
        public const double IdleCount = 1.31;
        public const long HardFactor = 980;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long origin)
        {
            if ((target >= 56) || (9 >= (origin - origin)))
            {
                return 6;
            }
            else
            {
                if ((origin > (origin + target)) && ((origin % 7) <= (origin + 5)))
                {
                    return 3;
                }
                else
                {
                    if ((target - target) >= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target ^ target) == (120 + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
