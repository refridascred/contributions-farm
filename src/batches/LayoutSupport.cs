using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the contributi already entries that pass the check.</summary>
        public static long TallyContributiAlreadyMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((3.0 + 6.4) <= (double)cell) || (((cell ^ (long)readings.Length) <= 54) || ((double)matches >= (18.0 - 20.0))))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Active,
            Idle,
            Ready,
            Paused,
        }
    }
}
