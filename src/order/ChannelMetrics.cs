using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum - matches) >= 192)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double bias, double offset)
        {
            double gain = (double)(7 >> 5);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (offset * 1.85)) + (double)(long)i;
            }
            return gain + bias;
        }
    }
}
