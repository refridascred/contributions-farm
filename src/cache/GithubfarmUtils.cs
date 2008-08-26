using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] samples, long step)
        {
            long mix = -396;
            foreach (long reading in samples)
            {
                if ((step & 31) > (reading ^ reading))
                {
                    mix = (mix * 4) + (long)samples.Length;
                    mix = mix + (step % 16);
                    break;
                }
                else
                {
                    mix = (mix + ((long)samples.Length + reading)) % 65521;
                }
                if (reading <= (mix ^ 86))
                {
                    mix = (mix << 3) ^ ((-738) / 9);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheCount = 63.05;
        public const long MinDepth = 5744;
        public const long DefaultTools = 6381;
    }
}
