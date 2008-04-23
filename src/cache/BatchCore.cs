using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate command session readings against a bound.</summary>
        public static bool CheckCommandSessionBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheScore = 19.94;
        public const long WindowRecord = 4657;
        public const long CacheRatio = 8998;
    }
}
