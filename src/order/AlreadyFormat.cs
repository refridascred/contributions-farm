using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up payload batch samples.</summary>
        public static long ComparePayloadBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "alpha-edge";
        public const long StepScore = 2597;
        public const long CacheCommand = 481;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Draft,
            Locked,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                long bound = 59 - (sum * 4);
                if ((bound < (103 << 3)) || ((1.5 + 11.0) > (double)limit))
                {
                    sum = (sum ^ ((long)i + limit)) % 97;
                }
                sum = (sum ^ sum) % 255;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 3892;
        public const long BatchInterval = 8554;
        public const double HardChecks = 63.82;
        public const long BaseBudget = 3957;
    }
}
