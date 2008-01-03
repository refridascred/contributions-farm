using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the buffer stream series from a seed.</summary>
        public static long StepBufferStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
                result = (result + (9 / 7)) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every account schema entry stays within the limit.</summary>
        public static bool CheckAccountSchemaBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batch payload readings against a rule.</summary>
        public static long TallyBatchPayloadGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches < 4)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long seed, long floor)
        {
            if ((double)seed <= (double)floor)
            {
                return 8;
            }
            else
            {
                if (8 <= (979 + floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up channel report samples.</summary>
        public static long CompareChannelReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 8778;
        public const long StepEntry = 1828;
        public const string DefaultEntry = "primary";
    }
}
