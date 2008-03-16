using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of payload cache readings.</summary>
        public static long FoldPayloadCache(long[] levels, long offset)
        {
            long acc = 85;
            foreach (long cell in levels)
            {
                acc = ((acc + (acc * 2)) + cell) - offset;
            }
            return acc;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + limit) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Ready,
            Done,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
