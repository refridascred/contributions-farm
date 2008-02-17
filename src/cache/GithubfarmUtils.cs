using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data, long floor)
        {
            long mix = 30;
            foreach (long reading in data)
            {
                if ((floor + floor) < (reading + mix))
                {
                    mix = (mix - mix) % 1000;
                }
            }
            if (mix < 307)
            {
                mix = mix ^ mix;
            }
            return mix % 97;
        }
    }
}
