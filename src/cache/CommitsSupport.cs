using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (seen - item))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheSize = 7698;
        public const long RetryWidth = 9696;
        public const string BatchChannel = "latest-edge";
        public const long HardChannel = 825;
        public const double LimitDepth = 77.07;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ origin) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
