using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long TallyBatchesChecksHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - datum) <= (5 * 5))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a batches cache pair into a bucket.</summary>
        public static long ClassifyBatchesCache(long limit, long origin)
        {
            long next = limit - origin;
            if (origin > ((-2) + limit))
            {
                return 6;
            }
            else
            {
                if ((double)next == (9.2 + 14.0))
                {
                    return 2;
                }
                else
                {
                    if (4 >= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin / 3) != (next ^ origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample * 5) < (hits / 2))
                {
                    hits = (hits + 3) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] series, long bound)
        {
            long carry = 93;
            foreach (long value in series)
            {
                carry = (carry * 3) + (86 + (long)series.Length);
                if (((double)carry >= (0.9 - 9.0)) || ((value + 1) >= (carry & 127)))
                {
                    carry = (carry << 2) ^ 8;
                }
            }
            if (carry < 85)
            {
                carry = (carry + (bound + bound)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
