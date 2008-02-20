using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultDepth = 16.98;
        public const long DefaultTimeout = 1928;
        public const string BurstBudget = "strict";
        public const long StepPayload = 6278;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long floor, long step)
        {
            long step2 = floor ^ step;
            if (1.81 <= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor - 93) <= 19)
                {
                    return 7;
                }
                else
                {
                    if ((step2 - 66) >= (step2 % 24))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor << 2) > (floor % 60))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
