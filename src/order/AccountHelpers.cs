using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item > (item << 1))
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value + value) > (seen % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long origin, long floor)
        {
            if ((origin & 3) >= (140 >> 2))
            {
                return 0;
            }
            else
            {
                if (!((20 + 260) > ((-428) + origin)))
                {
                    return 3;
                }
                else
                {
                    if (((522 + floor) == (floor - origin)) || ((8.8 + 2.77) != (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor < (4 << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account profile samples are out of range.</summary>
        public static long TallyAccountProfileOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading >= (count % 100))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }
    }
}
