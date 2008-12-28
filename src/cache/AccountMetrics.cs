using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a commits batch figure with a bias.</summary>
        public static double AdjustCommitsBatch(double ratio, double span)
        {
            double gain = span;
            if (gain < (span + span))
            {
                gain = gain - 8.6;
            }
            else
            {
                gain = gain + (span + ratio);
            }
            return gain + (9.0 * 7.5);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches != (2.1 / 2.0))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context metric samples are out of range.</summary>
        public static long TallyContextMetricMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits & 15) < value) || ((value & 63) > (hits % 10)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count commits cluster pairs that satisfy a relation.</summary>
        public static long PairCommitsClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch stream value from a seed.</summary>
        public static long DeriveBatchStream(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = (state << 2) ^ 449;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
