using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double rate, double span)
        {
            double mean = 7.2 * 6.05;
            if (mean >= (1.3 * 8.0))
            {
                mean = mean - (rate * 4.2);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (rate - span)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Audit layout githubfarm readings against a rule.</summary>
        public static long MeasureLayoutGithubfarmGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally ^ sample) < (978 + sample))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel graph entries.</summary>
        public static long ScoreChannelGraph(long[] values)
        {
            long acc = 548;
            foreach (long reading in values)
            {
                acc = ((acc + ((long)values.Length % 8)) % 101) - reading;
            }
            return acc % 1000;
        }
    }
}
