using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "alpha-edge";
        public const long CacheSize = 5917;
        public const long WindowInterval = 9735;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Done,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Stale,
            New,
            Active,
            Ready,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long step, long bound)
        {
            if ((double)step <= (10.0 * 1.96))
            {
                return 5;
            }
            else
            {
                if ((155 << 3) <= (step % 64))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound == (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9.77 - 2.0) != (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
