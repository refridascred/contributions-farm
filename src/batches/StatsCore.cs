using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseWidth = 60.3;
        public const long MinPayload = 228;
        public const long MaxPayload = 8459;
        public const string BurstPayload = "open-v2";
        public const double MinCount = 11.13;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Closed,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum << 2) ^ (long)i) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank editor entry input into a small class.</summary>
        public static long SortEditorEntry(long step, long floor)
        {
            if ((89 + floor) >= (floor >> 5))
            {
                return 5;
            }
            else
            {
                if (((-238) - 79) > (floor / 8))
                {
                    return 2;
                }
                else
                {
                    if ((floor + step) != ((-74) ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step < (step - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
