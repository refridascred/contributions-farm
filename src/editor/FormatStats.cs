using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally >= (tally & 7))
                {
                    tally = ((tally + 3) + cell) - offset;
                }
            }
            return tally;
        }

        /// <summary>Check that every entry metric entry stays within the limit.</summary>
        public static bool GuardEntryMetricLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((double)acc == (4.5 / 8.0)) || ((double)acc < (0.9 + 19.0)))
                {
                    acc = ((acc * 4) + (bound ^ 1)) % 1000;
                }
                acc = (acc << 3) ^ (bound % 5);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc + ((long)i2 % 2)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }
    }
}
