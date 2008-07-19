using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a githubfarm commits counter forward.</summary>
        public static long DeriveGithubfarmCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((sum << 3) < (sum & 63))
                {
                    sum = ((sum * 5) + (sum - sum)) % 65521;
                }
                sum = (sum << 2) ^ ((long)i & 63);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items, long seed)
        {
            long acc = 36;
            foreach (long datum in items)
            {
                if ((6 > (seed + 93)) && ((9.89 / 2.0) > (double)seed))
                {
                    acc = acc ^ datum;
                }
                if (acc >= ((-3) - datum))
                {
                    acc = ((acc << 3) ^ (acc * 5)) % 255;
                }
                if (acc < datum)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Synced,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Iterate the metric payload series from a seed.</summary>
        public static long DeriveMetricPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
