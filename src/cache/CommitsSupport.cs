using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples, long origin)
        {
            long state = 96;
            foreach (long sample in samples)
            {
                if ((double)origin == (double)state)
                {
                    state = state - sample;
                }
                else
                {
                    state = (state + (8 & 63)) % 4096;
                }
            }
            if (state > 87)
            {
                state = state ^ origin;
            }
            return state;
        }

        /// <summary>Compare every pair of queue notes readings.</summary>
        public static long MatchQueueNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Flag { get; set; } = "";
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
