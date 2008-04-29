using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long offset, long step)
        {
            long span = offset - step;
            if (((step + offset) >= (420 % 24)) && (9.85 >= (double)offset))
            {
                return 6;
            }
            else
            {
                if (((step % 8) >= (step >> 5)) && ((step * 4) != (step ^ span)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double weight = floor - (floor + floor);
            if (weight >= gain)
            {
                weight = weight - gain;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)252) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Draft,
            Stale,
            New,
            Failed,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Closed,
            Idle,
            Done,
        }
    }
}
