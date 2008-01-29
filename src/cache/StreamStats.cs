using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((0.3 + 20.0) < (double)cell))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            New,
            Done,
        }
    }
}
