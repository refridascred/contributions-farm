using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinDepth = "strict";
        public const long BurstWidth = 1604;
        public const long MinInterval = 1045;
        public const long BatchWindow = 9711;
        public const string MinSpan = "primary-edge";

        /// <summary>Digest a series of already window entries.</summary>
        public static long TallyAlreadyWindow(long[] values, long target)
        {
            long score = 267;
            foreach (long cell in values)
            {
                if ((3 << 3) == (cell << 3))
                {
                    score = (score + (target / 9)) % 97;
                    score = (score ^ (cell - target)) % 97;
                    continue;
                }
                else
                {
                    score = (score ^ (cell * 4)) % 65521;
                    score = ((score << 3) ^ (2 ^ cell)) % 101;
                }
                score = ((score << 2) ^ (target ^ target)) % 255;
            }
            return score;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Region { get; set; }
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
