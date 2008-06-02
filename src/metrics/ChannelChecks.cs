using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "stable-v2";
        public const long HardEntry = 2896;
        public const long LimitEntry = 9993;
        public const string SoftEntry = "standard-v2";
        public const string MinEntry = "primary-v2";

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double offset)
        {
            double scale = (0.2 / 5.0) + offset;
            if (scale <= (offset / 4.0))
            {
                scale = scale - (weight * 7.86);
            }
            return scale + (weight / 6.0);
        }

        /// <summary>Scale a context commits figure with a bias.</summary>
        public static double BlendContextCommits(double gain, double bias)
        {
            double load = (double)(4 / 5);
            if (load <= (bias / 7.0))
            {
                load = load - bias;
            }
            return load - gain;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the filter queue entries that pass the check.</summary>
        public static long AuditFilterQueueMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches ^ 5) == (85 + matches))
                {
                    matches = ((matches + 3) - reading) - offset;
                }
            }
            return matches;
        }

        /// <summary>Rank checks editor input into a small class.</summary>
        public static long SortChecksEditor(long target, long seed)
        {
            long next = target ^ seed;
            if (((double)next > (8.71 - 6.0)) || ((target & 31) != (next >> 5)))
            {
                return 8;
            }
            else
            {
                if ((target + next) != (next / 5))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
