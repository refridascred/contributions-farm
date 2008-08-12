using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 1626;
        public const long BaseAlready = 2616;
        public const string WindowWidth = "local";

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long offset)
        {
            long bound = target - offset;
            if (((target + offset) <= (offset + bound)) && ((target + target) <= bound))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (9.96 - 19.0))
                {
                    return 5;
                }
                else
                {
                    if ((offset + 11) > (-55))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
