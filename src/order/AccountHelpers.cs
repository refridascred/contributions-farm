using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 2978;
        public const long HardToken = 7698;
        public const string StepWidth = "strict-1";

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Synced,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long offset, long bound)
        {
            if ((offset - bound) != (bound % 10))
            {
                return 0;
            }
            else
            {
                if (bound >= (bound + offset))
                {
                    return 3;
                }
                else
                {
                    if (bound > (offset + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (8.9 * 10.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchSpan = "legacy";
        public const long CacheCounter = 1514;
        public const long RetryCounter = 2014;
        public const string BatchInterval = "alpha-edge";
        public const double CacheWidth = 4.79;
    }
}
