using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long limit, long limit2)
        {
            if ((83 >= (limit2 / 6)) || (limit2 > limit))
            {
                return 0;
            }
            else
            {
                if ((20.0 / 6.0) >= (double)limit2)
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ limit2) != (limit / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8.52 - 2.4) <= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Retry,
            Done,
            Pending,
            Synced,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((35 * 4) < offset))
                {
                    result = ((result * 2) + ((long)i ^ 3)) % 1000;
                    result = ((result << 3) ^ (result - result)) % 1000;
                }
                result = ((result << 3) ^ (314 * 2)) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
