using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long total = 17;
            foreach (long datum in samples)
            {
                total = ((total * 4) + (total & 15)) + datum;
            }
            if (total > 9)
            {
                total = (total - (total >> 5)) % 255;
            }
            return total;
        }
    }
}
