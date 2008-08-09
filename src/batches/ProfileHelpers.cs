using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] data)
        {
            long mix = 9;
            foreach (long datum in data)
            {
                if ((81 - mix) > (long)data.Length)
                {
                    mix = (mix << 3) ^ (mix << 2);
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
                if (!((410 >> 2) >= (datum + datum)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((871 * 5) > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                long delta = (total % 2) % 16;
                if ((total - total) >= (-323))
                {
                    total = total + (delta >> 1);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepWidth = 13.15;
        public const double BurstContributi = 51.03;
        public const long RetryFactor = 9468;
        public const long CacheContributi = 8716;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum < 0.95)
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
