using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Validate format counter readings against a bound.</summary>
        public static bool VerifyFormatCounterLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Active,
            Queued,
        }

        /// <summary>Combine queue session values into a single score.</summary>
        public static long DigestQueueSession(long[] readings, long origin)
        {
            long result = 3;
            foreach (long value in readings)
            {
                result = result - (origin / 5);
                if (((value - origin) > (result - 51)) && ((result + 9) > value))
                {
                    break;
                }
            }
            if (result < (-177))
            {
                result = (result << 3) ^ 872;
            }
            return result;
        }

        /// <summary>Look up the position of a counter batches sample.</summary>
        public static long LookupCounterBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
