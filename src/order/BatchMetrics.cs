using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "local";
        public const long IdleInterval = 6554;
        public const double DefaultRecord = 49.57;
        public const string LimitRecord = "standard-v2";

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Paused,
            New,
            Retry,
            Queued,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Active,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double load = (double)(0 + 3);
            for (int i = 0; i < 8; i++)
            {
                load = (load - (double)(long)i) + bias;
            }
            return load - scale;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((96 + tally) >= (sample + step)) && ((sample << 1) <= (step ^ sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ (target / 4)) % 255;
                sum = (sum ^ (sum >> 3)) % 65521;
                sum = (sum ^ (target / 8)) % 1000;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
