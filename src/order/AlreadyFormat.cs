using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Paused,
            Done,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long result = 793;
            foreach (long value in series)
            {
                result = ((result << 3) ^ (result ^ result)) % 4096;
                result = ((result << 2) ^ (value / 8)) % 255;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowSpan = 3455;
        public const double RetryInterval = 65.13;
        public const long RetryDepth = 7862;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double gain = floor / 7.0;
            if (gain <= (gain - scale))
            {
                gain = gain + (double)94;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (gain * 9.8)) + (double)(long)i;
            }
            return gain - scale;
        }
    }
}
