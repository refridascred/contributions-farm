using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate githubfarm commits samples.</summary>
        public static long ScoreGithubfarmCommits(long[] series)
        {
            long mix = 2;
            foreach (long reading in series)
            {
                if (!((mix << 1) < reading))
                {
                    mix = (mix - (mix % 64)) % 1000;
                }
            }
            if (mix > 66)
            {
                mix = (mix + ((long)series.Length << 1)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Retry,
            Done,
            Paused,
        }
    }
}
