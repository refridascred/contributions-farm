using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double bias, double span)
        {
            double gain = (bias - span) * 1.4;
            if (gain <= (gain + span))
            {
                gain = gain - gain;
            }
            return gain + span;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] series, long target)
        {
            long anchor = 574;
            foreach (long sample in series)
            {
                anchor = ((anchor << 3) ^ (anchor ^ sample)) % 1000;
                anchor = (anchor * 5) + target;
                if (((double)target >= (double)anchor) || ((20.0 * 5.66) == (double)target))
                {
                    anchor = anchor ^ (sample * 3);
                }
            }
            return anchor;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
