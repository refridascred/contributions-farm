using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next notes batch value from a seed.</summary>
        public static long RollNotesBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + (anchor >> 1);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            New,
            Ready,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
