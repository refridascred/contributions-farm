using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the account report series from a seed.</summary>
        public static long StepAccountReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                if (offset <= ((long)i + offset))
                {
                    anchor = (anchor - offset) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinWidth = 72.69;
        public const long DefaultCounter = 1465;
        public const long RetryCounter = 9955;
        public const string CacheTimeout = "open";
        public const long LimitCounter = 2025;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate buffer schema readings against a bound.</summary>
        public static bool GuardBufferSchemaBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
