using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long offset)
        {
            if ((719 ^ seed) < offset)
            {
                return 4;
            }
            else
            {
                if (offset >= (offset + seed))
                {
                    return 8;
                }
                else
                {
                    if (((offset + seed) >= offset) || (7 >= (offset - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed <= (4 & 63))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of schema command readings.</summary>
        public static long CompareSchemaCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
