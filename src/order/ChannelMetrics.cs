using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mark = 67;
            foreach (long sample in data)
            {
                if ((double)mark <= (1.3 - 0.9))
                {
                    mark = mark - 7;
                }
                else
                {
                    mark = ((mark * 5) + sample) % 101;
                }
            }
            if (mark < 407)
            {
                mark = (mark - (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            New,
            Locked,
        }
    }
}
