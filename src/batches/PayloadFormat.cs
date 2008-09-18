using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleInterval = 1973;
        public const long WindowRecord = 6220;
        public const long BurstRecord = 5412;
        public const long IdleFactor = 2822;
        public const long StepRecord = 8652;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long floor)
        {
            long span = limit + floor;
            if (!((919 % 8) != (limit + limit)))
            {
                return 2;
            }
            else
            {
                if ((limit >> 2) >= limit)
                {
                    return 3;
                }
                else
                {
                    if (span < (floor % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up buffer already samples.</summary>
        public static long CompareBufferAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
