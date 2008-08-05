using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinBudget = 7156;
        public const long BurstAlready = 3528;
        public const double DefaultLevel = 87.4;

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = (score << 2) ^ (score << 2);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((9 + offset) == (acc / 2))
                {
                    acc = acc - (long)i;
                }
                else
                {
                    acc = (acc * 2) + (offset + offset);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next schema stream value from a seed.</summary>
        public static long IterateSchemaStream(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = (total * 2) + target;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
