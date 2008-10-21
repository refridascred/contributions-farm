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

        /// <summary>Combine format route values into a single score.</summary>
        public static long DigestFormatRoute(long[] readings, long floor)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                if (((carry - carry) >= (carry % 5)) && ((datum + floor) > datum))
                {
                    carry = ((carry * 3) + (floor << 2)) % 4096;
                }
            }
            return carry;
        }

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

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Draft,
            Pending,
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
