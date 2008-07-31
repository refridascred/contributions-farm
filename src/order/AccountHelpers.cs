using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix << 3) ^ target;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long floor, long bound)
        {
            long offset = floor - bound;
            if (bound <= floor)
            {
                return 0;
            }
            else
            {
                if (((bound % 60) < (bound << 2)) && ((2.0 - 14.0) != (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double gain, double span)
        {
            double mean = (double)536 / 4.0;
            if (mean > gain)
            {
                mean = (mean - 9.0) - span;
            }
            return mean + gain;
        }
    }
}
