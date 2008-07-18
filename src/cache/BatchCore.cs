using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Draft,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long mark = 51;
            foreach (long value in data)
            {
                if ((mark * 3) > mark)
                {
                    mark = (mark ^ value) % 101;
                }
                if (value > (mark ^ value))
                {
                    mark = ((mark * 4) + value) % 255;
                }
                else
                {
                    mark = (mark + (value * 5)) % 255;
                }
                if (((double)value == (3.0 / 8.0)) || (8.7 < (double)(long)data.Length))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
