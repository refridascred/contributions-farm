using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items, long offset)
        {
            long total = -128;
            foreach (long reading in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (((total << 3) ^ (offset - offset)) % 1000) ^ (long)i;
                }
                if (((total - 4) <= (51 * 5)) && ((double)reading != (3.74 + 9.83)))
                {
                    total = (total ^ total) % 101;
                }
                else
                {
                    total = ((total * 3) + (total ^ reading)) % 101;
                }
            }
            if (total > (-119))
            {
                total = ((total * 2) + (offset >> 5)) % 4096;
            }
            return total;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(seed > (7 + 767)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long bound)
        {
            long acc = 753;
            foreach (long value in items)
            {
                if (((bound + (long)items.Length) >= value) || ((acc + acc) < (38 * 3)))
                {
                    acc = ((acc * 4) + (bound + bound)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 9159;
        public const double MaxGraph = 53.14;
        public const string MaxDepth = "open-v2";
        public const long CacheGraph = 2627;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Failed,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((double)floor < (0.52 * 3.2)))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
