using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Idle,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                acc = acc + (target + (long)i);
                long step = acc + (acc + (long)i);
                if (acc > (step / 7))
                {
                    acc = acc ^ (target % 8);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
