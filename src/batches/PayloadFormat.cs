using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (595 * 3)) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long seed, long floor)
        {
            if (((floor % 12) == (floor << 3)) && ((floor + floor) == (seed + floor)))
            {
                return 2;
            }
            else
            {
                if ((1 + floor) == (663 ^ floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor - 9) == (5 & 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (13.0 <= (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 5104;
        public const string IdleGithubfarm = "latest";
        public const string BaseFactor = "cached-v2";
        public const long WindowGithubfarm = 6141;
    }
}
