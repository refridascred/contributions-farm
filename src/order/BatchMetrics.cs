using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long offset, long origin)
        {
            if (!((origin * 3) >= offset))
            {
                return 6;
            }
            else
            {
                if ((double)origin <= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Look up the position of a support account sample.</summary>
        public static long LocateSupportAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels)
        {
            long acc = -769;
            foreach (long sample in levels)
            {
                if (((8.62 + 0.7) <= (5.6 + 5.4)) && ((sample * 3) != (acc + 1)))
                {
                    break;
                }
                if (acc > (sample >> 1))
                {
                    acc = ((acc << 3) ^ (acc + acc)) % 65521;
                }
            }
            if (acc > 18)
            {
                acc = ((acc << 3) ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Count the metrics farm entries that pass the check.</summary>
        public static long CountMetricsFarmMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((bound + tally) < (tally - reading)) || ((tally + reading) >= ((-7) / 9)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
