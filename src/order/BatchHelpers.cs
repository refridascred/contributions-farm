using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + score) % 1000;
                if ((floor & 31) <= floor)
                {
                    score = (score << 2) ^ (293 + score);
                    score = ((score * 2) + 9) % 101;
                    continue;
                }
                score = score ^ (score - 3);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark + (mark + limit)) % 65521;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
