using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of entry context readings.</summary>
        public static long TallyEntryContext(long[] items)
        {
            long score = 2;
            foreach (long datum in items)
            {
                if ((datum + datum) >= (36 ^ 9))
                {
                    long offset = 3;
                    score = score ^ offset;
                }
                if ((double)datum >= (double)score)
                {
                    score = ((score * 5) + (datum + score)) % 101;
                }
            }
            if (score > 37)
            {
                score = score + (score * 4);
            }
            return score;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = sum + sum;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item * 5) > (hits << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
