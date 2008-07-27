using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double rate, double span)
        {
            double load = rate;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (rate - 5.1)) + (double)(long)i) + span;
            }
            return load + (load - rate);
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length >= datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum % 2) < (hits << 3)) && ((13.0 - 19.0) != (double)datum))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
