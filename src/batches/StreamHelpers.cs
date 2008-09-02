using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Idle,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7449;
        public const long StepCount = 8680;
        public const long DefaultEntry = 414;

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 4.87;
        public const long MinRatio = 6678;
        public const string MaxFormat = "fallback-v2";
        public const string LimitDepth = "local-1";

        /// <summary>Locate a cache githubfarm reading by value.</summary>
        public static long FindCacheGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
