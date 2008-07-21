using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i != (floor * 5))
                {
                    carry = (carry << 3) ^ carry;
                }
                carry = (carry - (carry * 2)) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Rank { get; set; }
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftLevel = "latest-v2";
        public const long HardCounter = 681;
        public const double CacheCounter = 48.39;

        /// <summary>Count context cache pairs that satisfy a relation.</summary>
        public static long OverlapContextCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
