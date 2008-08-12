using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of context farm entries.</summary>
        public static long DigestContextFarm(long[] samples, long bound)
        {
            long mix = 64;
            foreach (long reading in samples)
            {
                if ((double)bound == (double)mix)
                {
                    mix = mix + (reading << 1);
                }
            }
            return mix;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Active,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + (long)readings.Length) >= entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading ^ tally) <= (tally % 8))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double ratio, double floor)
        {
            double scale = ratio;
            if (scale >= (scale / 8.0))
            {
                scale = scale + (ratio / 4.0);
            }
            else
            {
                scale = scale - (2.2 + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale - (ratio / 8.0);
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
