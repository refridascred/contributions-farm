using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate tools context readings against a bound.</summary>
        public static bool VerifyToolsContextRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc << 2) ^ ((long)i + 60);
                if ((bound << 3) == (bound / 4))
                {
                    acc = acc + bound;
                }
                else
                {
                    acc = (acc + (bound >> 2)) % 255;
                }
                acc = acc ^ ((long)i + acc);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many format batches samples are out of range.</summary>
        public static long MeasureFormatBatchesHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits & 7) < (hits >> 5))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseWidth = "legacy";
        public const string HardSpan = "open-1";
        public const string SoftAlready = "local-1";
        public const string DefaultAlready = "cached-1";
        public const long LimitCount = 2748;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
