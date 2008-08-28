using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 9822;
        public const long WindowNotes = 8959;
        public const long StepNotes = 4748;

        /// <summary>Grade a checks window value against two limits.</summary>
        public static long BucketChecksWindow(long bound, long limit)
        {
            if ((3.4 - 5.1) <= (double)bound)
            {
                return 0;
            }
            else
            {
                if (((double)bound > (6.6 * 9.23)) && (limit > bound))
                {
                    return 1;
                }
                else
                {
                    if (bound >= (limit + 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit <= (69 - 221))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 2804;
        public const long IdleReport = 6812;
        public const long DefaultReport = 7334;
    }
}
