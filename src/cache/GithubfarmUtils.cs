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

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double load = floor * 7.0;
            if (load < 6.1)
            {
                load = (load - 3.73) - ratio;
            }
            else
            {
                load = load + 3.2;
            }
            return load + floor;
        }
    }
}
