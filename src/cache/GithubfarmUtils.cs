using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the batches layout series from a seed.</summary>
        public static long RollBatchesLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 2) ^ (score & 3)) % 4096;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Ready,
            Draft,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double ratio2 = bias + (bias / 6.0);
            if (ratio2 >= (ratio * 13.0))
            {
                ratio2 = ratio2 - (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - bias) + (double)(long)i;
            }
            return ratio2 - (ratio - ratio);
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            Stale,
            Failed,
            Queued,
        }
    }
}
