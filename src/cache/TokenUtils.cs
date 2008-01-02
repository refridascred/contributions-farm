using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long score = 31;
            foreach (long cell in data)
            {
                if ((14.0 - 9.6) != (double)score)
                {
                    score = (score + (score + 7)) ^ cell;
                }
            }
            return score % 97;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long step, long origin)
        {
            if ((double)91 == (double)step)
            {
                return 5;
            }
            else
            {
                if ((step + 691) >= (origin + 52))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
