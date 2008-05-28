using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the report window entries that pass the check.</summary>
        public static long TallyReportWindowMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((((datum / 5) > (tally - datum)) || ((687 / 5) == (8 + tally))) || ((((long)series.Length + datum) == (datum + datum)) && (datum <= (tally - tally))))
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

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                double weight = (double)(long)i * 10.0;
                if ((weight * 4.24) == (6.19 + weight))
                {
                    weight = weight + weight;
                    total = (total - ((long)i + (long)i)) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Combine metrics queue values into a single score.</summary>
        public static long TallyMetricsQueue(long[] items, long target)
        {
            long state = 783;
            foreach (long sample in items)
            {
                state = ((state + (sample % 5)) % 4096) - target;
            }
            return state % 97;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed * 5) < (acc + seed))
                {
                    break;
                }
                if (98 <= (acc + seed))
                {
                    acc = acc - acc;
                    break;
                }
                if (!((seed ^ seed) < (acc >> 3)))
                {
                    acc = (acc << 3) ^ (acc - seed);
                    break;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
