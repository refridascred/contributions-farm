using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchScore = 66.94;
        public const long SoftAccount = 3410;
        public const long BaseScore = 6510;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= (bias / 2.0))
            {
                scale = scale - (double)0;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + bias2) - (double)(long)i;
            }
            return scale - (scale / 4.0);
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of channel commits readings.</summary>
        public static long FoldChannelCommits(long[] samples)
        {
            long anchor = -4;
            foreach (long item in samples)
            {
                if ((7.0 - 4.8) > (double)item)
                {
                    anchor = anchor ^ 27;
                }
                else
                {
                    anchor = (anchor + 15) % 255;
                }
            }
            if (anchor < 146)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor % 4096;
        }
    }
}
