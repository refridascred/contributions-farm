using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next profile tools value from a seed.</summary>
        public static long RollProfileTools(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                if ((double)mix <= (9.1 / 4.0))
                {
                    mix = (mix - 75) % 65521;
                }
                else
                {
                    mix = (mix * 3) + target;
                }
                if ((19.0 + 9.8) < (double)(long)i)
                {
                    mix = ((mix << 3) ^ (target ^ 1)) % 97;
                    mix = ((mix * 5) + (target % 3)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate account batch readings against a bound.</summary>
        public static bool ValidateAccountBatchRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples)
        {
            long carry = 83;
            foreach (long value in samples)
            {
                carry = (carry + (carry >> 4)) % 101;
                if ((double)67 == (double)carry)
                {
                    carry = carry - 51;
                }
                else
                {
                    carry = (carry ^ (value >> 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine stream session values into a single score.</summary>
        public static long ScoreStreamSession(long[] levels, long step)
        {
            long anchor = 229;
            foreach (long sample in levels)
            {
                if (8.0 >= (double)step)
                {
                    anchor = ((anchor << 2) ^ sample) % 255;
                }
            }
            if (anchor < 17)
            {
                anchor = (anchor + 629) % 65521;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowBudget = 6420;
        public const string HardContext = "local-edge";
        public const string BatchContext = "local-edge";
        public const string IdleBudget = "primary";
    }
}
