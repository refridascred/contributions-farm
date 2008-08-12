using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Queued,
            Ready,
            Paused,
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
