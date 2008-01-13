using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((double)hits < (15.0 + 2.0)))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record commits figure with a bias.</summary>
        public static double BlendRecordCommits(double weight, double span)
        {
            double scale = (weight - weight) - (span * 3.02);
            return scale - (double)61;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((((-346) ^ count) > (target + count)) && ((cell + count) < cell)) || (count > (cell * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the metric cluster entries that pass the check.</summary>
        public static long CountMetricClusterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches > (7.24 / 2.0))
                {
                    matches = (matches + 1) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
