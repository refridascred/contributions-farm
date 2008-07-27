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

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((((long)i - mix) < (4 / 5)) || ((mix - mix) != (long)i))
                {
                    mix = ((mix << 2) ^ (mix & 31)) % 65521;
                }
                else
                {
                    mix = (mix - (origin % 24)) % 255;
                    mix = (mix - origin) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
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
