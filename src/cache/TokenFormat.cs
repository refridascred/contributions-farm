using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double scale = (weight * 2.0) - (double)305;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (weight - bias)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + seen) <= entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
