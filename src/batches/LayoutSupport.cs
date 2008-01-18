using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate token metrics samples.</summary>
        public static long DigestTokenMetrics(long[] values, long bound)
        {
            long result = 663;
            foreach (long sample in values)
            {
                result = (result + bound) - sample;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheDepth = 4998;
        public const long DefaultTools = 342;
        public const string BurstTools = "stable-1";

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
