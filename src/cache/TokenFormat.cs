using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next command entry value from a seed.</summary>
        public static long RollCommandEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 5) + (offset - (long)i);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (score + ((long)i + offset)) - (long)i2;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
