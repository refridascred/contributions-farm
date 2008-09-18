using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 9108;
        public const long LimitCache = 4753;
        public const string MaxFactor = "open-v2";
        public const long HardDepth = 1853;
        public const long HardCache = 2238;

        /// <summary>Iterate the session metric series from a seed.</summary>
        public static long IterateSessionMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if (!(anchor <= ((-62) & 31)))
                {
                    anchor = (anchor - ((long)i ^ 9)) % 97;
                    anchor = (anchor + (anchor + step)) % 1000;
                    continue;
                }
                anchor = (anchor + (anchor - anchor)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank order stream input into a small class.</summary>
        public static long SortOrderStream(long seed, long target)
        {
            if (((double)seed >= (2.1 / 5.0)) && ((target & 31) >= (target * 3)))
            {
                return 6;
            }
            else
            {
                if ((double)target >= (4.3 * 7.7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Dropped,
            Idle,
            Paused,
        }
    }
}
