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

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long step, long target)
        {
            if ((double)step < (double)target)
            {
                return 6;
            }
            else
            {
                if (169 < step)
                {
                    return 4;
                }
                else
                {
                    if (6 < (step / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((11.0 - 7.88) != (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
