using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double scale, double offset)
        {
            double gain = offset;
            if (gain > gain)
            {
                gain = (gain - gain) + scale;
            }
            return gain - (offset + 9.6);
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value <= 1.0)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 2) ^ (state ^ (long)i)) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
