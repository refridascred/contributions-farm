using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long seed)
        {
            long span = origin ^ seed;
            if ((seed - origin) > seed)
            {
                return 4;
            }
            else
            {
                if ((origin << 2) <= 815)
                {
                    return 8;
                }
                else
                {
                    if (((seed << 3) > (seed - seed)) && (origin >= seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-15) / 4) <= (span - 797))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Check that every githubfarm editor entry stays within the limit.</summary>
        public static bool ValidateGithubfarmEditorLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 9995;
        public const string LimitSpan = "strict-edge";
        public const long WindowCounter = 5206;
        public const long RetryCounter = 5200;

        /// <summary>Audit cache context readings against a rule.</summary>
        public static long MeasureCacheContextOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + 45) >= (cell * 2))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
