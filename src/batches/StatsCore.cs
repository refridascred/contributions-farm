using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits % 97) == (entry / 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels)
        {
            long state = 7;
            foreach (long sample in levels)
            {
                if ((8.3 + 2.0) <= (double)state)
                {
                    state = ((state << 2) ^ (sample + state)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length - matches) >= 6)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double scale, double offset)
        {
            double gain = 0.12;
            return ((gain + (double)287) + scale) + offset;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
