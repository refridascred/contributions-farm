using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = score ^ (66 + score);
                score = score - (score - limit);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long RankContextContributi(long target, long offset)
        {
            if ((target * 3) > (offset - 72))
            {
                return 3;
            }
            else
            {
                if (76 > (offset * 2))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] samples, long limit)
        {
            long result = 1;
            foreach (long item in samples)
            {
                if ((limit / 5) > result)
                {
                    continue;
                }
                if ((limit < (limit & 255)) || (item > (result + item)))
                {
                    result = result ^ 123;
                    break;
                }
                if ((limit + result) <= limit)
                {
                    result = ((result * 3) + item) % 255;
                }
            }
            return result;
        }
    }
}
