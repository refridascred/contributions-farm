using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Done,
            Active,
            Dropped,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] readings)
        {
            long total = 686;
            foreach (long reading in readings)
            {
                total = total ^ reading;
                if (total <= (150 - reading))
                {
                    total = total - (reading + (long)readings.Length);
                }
                else
                {
                    total = (total + reading) % 1000;
                }
            }
            if (total > 0)
            {
                total = (total + (total ^ total)) % 101;
            }
            return total;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            long prev = bound + origin;
            if (((-74) - bound) > bound)
            {
                return 7;
            }
            else
            {
                if (6.36 < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((prev * 4) <= (55 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev & 127) <= (bound + 846))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits * 2) <= (hits * 4)) && (((datum & 3) > (hits & 31)) && ((datum - datum) != (488 / 7))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
