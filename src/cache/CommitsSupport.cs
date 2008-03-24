using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Total { get; set; }
            public double Flag { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long limit)
        {
            long prev = target + limit;
            if (((prev + target) <= (target * 3)) || ((double)target <= (16.0 * 9.0)))
            {
                return 7;
            }
            else
            {
                if ((limit > prev) && ((double)target != (5.3 * 4.73)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Score { get; set; }
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many route window samples are out of range.</summary>
        public static long CountRouteWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen <= (seen - 33))
                {
                    seen = (seen + 3) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((sum + 512) > sum) && ((double)floor == (6.0 - 2.9)))
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
