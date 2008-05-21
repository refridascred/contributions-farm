using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8234;
        public const double StepChecks = 61.6;
        public const long WindowScore = 6653;
        public const string CacheChecks = "open-v2";

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long floor)
        {
            long acc = 576;
            foreach (long entry in readings)
            {
                if ((5.9 - 1.4) < (double)entry)
                {
                    acc = acc ^ floor;
                }
                else
                {
                    acc = ((acc * 5) + (5 + entry)) % 255;
                }
                if ((double)floor <= (19.0 / 9.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Stale,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Locate a profile payload reading by value.</summary>
        public static long LookupProfilePayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric record series from a seed.</summary>
        public static long SeriesMetricRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset / 2) < offset)
                {
                    result = result ^ (result % 3);
                    result = result + result;
                }
                result = ((result * 5) + (offset - result)) % 255;
                result = (result ^ (result - offset)) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
