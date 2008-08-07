using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long limit, long seed)
        {
            if ((783 ^ limit) > (limit * 5))
            {
                return 7;
            }
            else
            {
                if (((8.4 - 2.6) <= (double)seed) && (limit > (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally % 3) == (cell / 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the format command entries that pass the check.</summary>
        public static long CountFormatCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + seen) <= (long)series.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate order account readings against a bound.</summary>
        public static bool GuardOrderAccountRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
