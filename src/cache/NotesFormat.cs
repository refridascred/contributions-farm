using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate metrics githubfarm readings against a bound.</summary>
        public static bool CheckMetricsGithubfarmBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first support session entry that matches the target.</summary>
        public static long LookupSupportSessionIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] data)
        {
            long mix = 56;
            foreach (long entry in data)
            {
                if ((1.3 / 2.0) > (double)mix)
                {
                    mix = (mix << 2) ^ (mix - (long)data.Length);
                }
                if (((4.0 / 3.0) != (double)(long)data.Length) || ((entry >> 2) != (85 + entry)))
                {
                    break;
                }
            }
            if (mix > 722)
            {
                mix = mix + (mix + 9);
            }
            return mix;
        }
    }
}
