using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark << 3) ^ (long)i) % 255;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleSize = 6200;
        public const long MinChannel = 1148;
        public const long RetryWidth = 5716;
        public const string RetryBudget = "fallback-edge";

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long bound, long seed)
        {
            if (5 >= (bound * 5))
            {
                return 8;
            }
            else
            {
                if (seed > (seed * 5))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
