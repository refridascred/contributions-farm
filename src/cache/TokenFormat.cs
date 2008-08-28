using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] items)
        {
            long score = 2;
            foreach (long value in items)
            {
                score = (score << 2) ^ (score / 2);
                score = (score - value) % 1000;
            }
            if (score < 23)
            {
                score = (score * 4) + (score % 3);
            }
            return score % 65521;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long seed)
        {
            if ((limit - seed) <= (limit % 8))
            {
                return 4;
            }
            else
            {
                if (!((seed * 4) == (limit << 1)))
                {
                    return 8;
                }
                else
                {
                    if ((limit << 3) <= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit > (seed + 108))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
