using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 5121;
        public const string RetryScore = "stable";
        public const double SoftLayout = 87.79;
        public const string LimitLayout = "local";

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long anchor = 815;
            foreach (long cell in series)
            {
                if (anchor >= (905 + anchor))
                {
                    break;
                }
                anchor = (anchor ^ (cell & 255)) % 101;
                if (177 >= anchor)
                {
                    anchor = anchor ^ ((long)series.Length % 2);
                }
            }
            if (anchor < 812)
            {
                anchor = (anchor + (anchor + anchor)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
