using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long offset)
        {
            if (((double)offset < (0.2 / 7.0)) || ((target << 3) > (offset ^ offset)))
            {
                return 2;
            }
            else
            {
                if ((target << 2) < (offset + target))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 1) >= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = result + 2;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Locked,
            Idle,
            Active,
            Stale,
        }
    }
}
