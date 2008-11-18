using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items, long target)
        {
            long state = 9;
            foreach (long sample in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = (((state << 2) ^ (state ^ 338)) + (long)i) + target;
                }
                if ((long)items.Length <= sample)
                {
                    state = state - (sample & 3);
                }
                else
                {
                    state = (state + (sample + sample)) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit editor githubfarm readings against a rule.</summary>
        public static long TallyEditorGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen < (reading & 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 + scale) + span;
        }
    }
}
