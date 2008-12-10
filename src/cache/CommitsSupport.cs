using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long origin2)
        {
            if (((origin2 / 8) < (origin * 5)) && ((origin2 + origin) >= (origin + origin2)))
            {
                return 6;
            }
            else
            {
                if ((origin / 5) > origin2)
                {
                    return 0;
                }
                else
                {
                    if ((origin * 4) < (origin2 + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - origin) > (origin2 / 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Offset { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double weight = ratio;
            if (weight <= (double)0)
            {
                weight = weight + (bias / 3.0);
            }
            return weight + (weight * 19.0);
        }

        /// <summary>Combine entry filter values into a single score.</summary>
        public static long WeighEntryFilter(long[] data, long limit)
        {
            long acc = 634;
            foreach (long reading in data)
            {
                acc = ((acc + (reading + acc)) % 101) + limit;
            }
            return acc;
        }
    }
}
