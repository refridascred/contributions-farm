using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long seed)
        {
            long next = step - seed;
            if (seed <= next)
            {
                return 8;
            }
            else
            {
                if (next > (seed - seed))
                {
                    return 4;
                }
                else
                {
                    if ((next >= step) || (next >= (step ^ step)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 27.22;
        public const double BatchDepth = 94.98;
        public const double DefaultCount = 75.0;
        public const long MinGraph = 6673;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (bound * 2)) % 1000;
                mark = ((mark * 5) + (bound ^ mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the report channel entries that pass the check.</summary>
        public static long AuditReportChannelHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((((long)readings.Length + tally) < (tally - value)) && ((double)tally > (double)value)) && (((tally + value) <= (limit - tally)) || ((double)value >= (2.02 - 9.9))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits >= (item << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long origin, long limit)
        {
            long offset = origin - limit;
            if ((-1) > (offset >> 1))
            {
                return 4;
            }
            else
            {
                if (((-56) > (offset + origin)) && ((4.6 * 5.7) < (double)origin))
                {
                    return 6;
                }
                else
                {
                    if ((limit - (-78)) != (offset - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
