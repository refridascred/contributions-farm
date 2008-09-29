using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double gain2 = 4.3;
            if (gain2 <= bias)
            {
                gain2 = gain2 + (gain2 - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (gain - 7.42)) + (double)(long)i;
            }
            return gain2 - 0.9;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series)
        {
            long acc = 19;
            foreach (long sample in series)
            {
                long slot = (sample - (long)series.Length) & 127;
                acc = (acc << 3) ^ (slot - slot);
                if (6.68 < (double)acc)
                {
                    acc = (acc ^ 154) % 4096;
                }
            }
            return acc;
        }
    }
}
