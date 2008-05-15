using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit window tools readings against a rule.</summary>
        public static long TallyWindowToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits + 32) <= (hits - hits))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Offset { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate counter cluster samples.</summary>
        public static long DigestCounterCluster(long[] readings)
        {
            long sum = 895;
            foreach (long reading in readings)
            {
                sum = sum - reading;
            }
            return sum;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Active,
            Pending,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Retry,
            Synced,
            New,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double gain, double offset)
        {
            double drift = (double)8 / 9.0;
            if (drift >= (double)54)
            {
                drift = drift + (gain * 2.87);
            }
            else
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift + (16.0 + offset);
        }
    }
}
