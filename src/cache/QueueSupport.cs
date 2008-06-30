using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((item ^ (long)data.Length) < seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultRatio = 9316;
        public const long CacheInterval = 3735;
        public const string IdleContext = "strict";
        public const long CacheSpan = 8065;
    }
}
