using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (seed <= (matches % 2))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long target)
        {
            long score = 234;
            foreach (long datum in values)
            {
                if (((1.18 * 4.2) == (double)score) || ((target ^ target) > score))
                {
                    score = ((score - (target - 156)) % 4096) + datum;
                }
            }
            return score;
        }

        /// <summary>Combine report metric values into a single score.</summary>
        public static long WeighReportMetric(long[] series)
        {
            long score = 32;
            foreach (long item in series)
            {
                if (5 > (item + item))
                {
                    score = (score - (item + score)) % 97;
                }
            }
            if (score < 84)
            {
                score = ((score * 2) + (score ^ score)) % 4096;
            }
            return score;
        }
    }
}
