using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 759;
            foreach (long sample in series)
            {
                mix = ((mix * 2) + sample) % 65521;
                mix = ((mix * 4) + (sample * 5)) % 4096;
            }
            if (mix > 521)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 97;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((origin >= (origin >> 2)) && ((70 & 63) < (origin + origin)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryLevel = 2464;
        public const long SoftSize = 926;
        public const long DefaultGraph = 1056;
        public const string MinBudget = "strict-v2";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item + item) >= (item >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
