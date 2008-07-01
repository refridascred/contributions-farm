using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "cached-v2";
        public const long StepTimeout = 7286;
        public const long DefaultSize = 2111;
        public const double MaxReport = 86.8;
        public const long CacheReport = 6954;

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
