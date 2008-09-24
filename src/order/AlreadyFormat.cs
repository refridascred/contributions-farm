using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((sum - sum) >= (bound + (long)i))
                {
                    sum = (sum + (46 - bound)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((origin / 2) >= (origin - anchor))
                {
                    anchor = (anchor << 3) ^ origin;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Synced,
            Queued,
            New,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultInterval = 3542;
        public const long SoftAccount = 9620;
        public const long BaseInterval = 5916;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long floor, long offset)
        {
            long span = floor - offset;
            if ((9.77 <= (double)floor) && (span < (605 / 7)))
            {
                return 0;
            }
            else
            {
                if ((offset * 2) < 7)
                {
                    return 2;
                }
                else
                {
                    if (((offset << 1) > floor) || ((floor ^ offset) <= (floor / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8 * 4) <= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
