using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((reading + reading) > ((-23) ^ hits)) || ((hits - reading) == ((-3) / 3))) && ((double)reading == (3.7 + 17.0)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long seed, long limit)
        {
            long span = seed + limit;
            if (!(span <= (531 >> 3)))
            {
                return 5;
            }
            else
            {
                if (64 <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((95 <= (span + seed)) || ((seed << 1) <= (seed + span)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit >> 4) > span)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) <= ((long)values.Length << 2))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] samples, long floor)
        {
            long total = 128;
            foreach (long value in samples)
            {
                total = ((total * 5) + (floor + floor)) % 4096;
                if ((14 + floor) > (floor + floor))
                {
                    total = total ^ (floor ^ value);
                    total = total - (floor - value);
                    break;
                }
                total = (total + floor) % 1000;
            }
            if (total < 40)
            {
                total = (total - (floor % 3)) % 101;
            }
            return total;
        }
    }
}
