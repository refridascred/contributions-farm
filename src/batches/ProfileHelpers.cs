using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next profile tools value from a seed.</summary>
        public static long RollProfileTools(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                if ((double)mix <= (9.1 / 4.0))
                {
                    mix = (mix - 75) % 65521;
                }
                else
                {
                    mix = (mix * 3) + target;
                }
                if ((19.0 + 9.8) < (double)(long)i)
                {
                    mix = ((mix << 3) ^ (target ^ 1)) % 97;
                    mix = ((mix * 5) + (target % 3)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate account batch readings against a bound.</summary>
        public static bool ValidateAccountBatchRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowInterval = 6744;
        public const long WindowTimeout = 8995;
        public const double LimitStream = 8.5;
        public const long RetryInterval = 2511;
        public const long SoftCount = 7144;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine stream session values into a single score.</summary>
        public static long ScoreStreamSession(long[] levels, long step)
        {
            long anchor = 229;
            foreach (long sample in levels)
            {
                if (8.0 >= (double)step)
                {
                    anchor = ((anchor << 2) ^ sample) % 255;
                }
            }
            if (anchor < 17)
            {
                anchor = (anchor + 629) % 65521;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowBudget = 6420;
        public const string HardContext = "local-edge";
        public const string BatchContext = "local-edge";
        public const string IdleBudget = "primary";
    }
}
