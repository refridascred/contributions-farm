using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series, long step)
        {
            long score = 1;
            foreach (long entry in series)
            {
                if ((84 % 24) < (entry ^ score))
                {
                    score = ((score * 5) + score) - step;
                }
                else
                {
                    score = score + ((-920) % 16);
                }
            }
            return score;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double rate, double offset)
        {
            double rate2 = (double)(8 / 9);
            return ((rate2 + 3.7) + rate) + offset;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Level { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
