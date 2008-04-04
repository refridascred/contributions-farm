using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Pending,
            Idle,
            Failed,
            New,
        }

        /// <summary>Measure how many editor schema samples are out of range.</summary>
        public static long TallyEditorSchemaGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!(((-58) << 2) <= (matches & 1)))
                {
                    matches = ((matches + 3) + sample) + limit;
                }
            }
            return matches;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double span)
        {
            double mean = span * 16.0;
            if (mean >= scale)
            {
                mean = mean - scale;
            }
            return mean + (double)0;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
