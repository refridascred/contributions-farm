using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a channel filter reading by value.</summary>
        public static long FindChannelFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 2898;
        public const double HardLevel = 14.87;
        public const long RetryCommits = 8378;
        public const long SoftScore = 8170;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((5.01 / 6.0) != (double)score)
                {
                    score = ((score << 2) ^ ((long)i - 3)) % 1000;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            New,
            Ready,
        }

        /// <summary>Classify a farm entry pair into a bucket.</summary>
        public static long GradeFarmEntry(long offset, long origin)
        {
            long edge = offset ^ origin;
            if ((7.9 + 7.0) != (double)offset)
            {
                return 3;
            }
            else
            {
                if (((10 & 1) > edge) && ((7 + (-8)) > offset))
                {
                    return 1;
                }
                else
                {
                    if (!((origin % 8) >= (offset / 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((edge * 4) > (offset << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
