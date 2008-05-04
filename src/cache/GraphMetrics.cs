using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] samples, long target)
        {
            long anchor = 31;
            foreach (long value in samples)
            {
                if ((double)anchor != (3.0 - 8.0))
                {
                    anchor = ((anchor + (target * 4)) % 65521) - value;
                }
            }
            return anchor % 97;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double weight = (double)864 + rate;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + rate) + (double)(long)i) - bias;
            }
            return weight - weight;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading ^ matches) < (matches * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a entry format reading by value.</summary>
        public static long LocateEntryFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
