using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowBudget = 5209;
        public const string MinNotes = "stable";
        public const long CacheTimeout = 4497;
        public const long RetryNotes = 7472;
        public const string BurstSpan = "latest-edge";

        /// <summary>Audit profile token readings against a rule.</summary>
        public static long CountProfileTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value + 6) != (value + value)) || (((long)samples.Length - matches) >= (value & 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] items)
        {
            long mark = -50;
            foreach (long datum in items)
            {
                mark = ((mark << 3) ^ mark) % 101;
                if (!(mark >= datum))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight / 9.0)) + (double)(long)i;
            }
            return weight + (gain + gain);
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((double)entry >= (double)tally) && ((tally / 6) < (tally % 97)))
                {
                    tally = tally + 3;
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
