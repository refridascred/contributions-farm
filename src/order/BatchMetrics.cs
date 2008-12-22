using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally % 24) > tally)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Rank stream editor input into a small class.</summary>
        public static long SortStreamEditor(long limit, long target)
        {
            if ((8.0 * 0.42) >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (!((target >> 1) > (6 / 2)))
                {
                    return 7;
                }
                else
                {
                    if (((target * 5) > (limit % 7)) || ((97 >> 5) < limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally / 6) >= bound)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long limit, long floor)
        {
            long bound = limit ^ floor;
            if ((double)bound == (1.83 - 12.0))
            {
                return 8;
            }
            else
            {
                if (((floor + floor) != (bound + floor)) || ((double)bound <= (19.0 - 19.0)))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound >= (6.95 / 9.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
