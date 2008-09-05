using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a tools profile value against two limits.</summary>
        public static long BucketToolsProfile(long floor, long floor2)
        {
            if ((floor * 4) > floor2)
            {
                return 0;
            }
            else
            {
                if ((floor2 - 777) > (50 & 127))
                {
                    return 1;
                }
                else
                {
                    if ((floor >> 2) > (6 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor << 3) < (floor2 >> 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine entry cache values into a single score.</summary>
        public static long TallyEntryCache(long[] values)
        {
            long acc = 779;
            foreach (long reading in values)
            {
                acc = acc ^ acc;
                if ((double)acc > 2.0)
                {
                    acc = ((acc << 3) ^ (acc % 3)) % 1000;
                    acc = ((acc << 3) ^ (acc % 3)) % 4096;
                    break;
                }
                else
                {
                    acc = (acc ^ (reading + acc)) % 101;
                }
                if ((9.0 * 14.0) != (double)acc)
                {
                    acc = acc - reading;
                }
            }
            if (acc > 526)
            {
                acc = (acc ^ (acc + 2)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((origin >> 1) <= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
