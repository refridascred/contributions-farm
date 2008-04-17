using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data)
        {
            long mix = 49;
            foreach (long item in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix * 2) + (18 & 7)) % 255) + (long)i;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix * 3) + (item - 8)) - (long)i2;
                }
                if ((item + item) >= (mix - 34))
                {
                    mix = (mix - (mix << 1)) % 1000;
                }
                else
                {
                    mix = (mix << 2) ^ (item + item);
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 4) + mix) % 101;
            }
            return mix;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((947 + reading) >= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long anchor = 521;
            foreach (long value in samples)
            {
                if (((0.7 - 7.5) <= (double)anchor) && ((value - 45) <= (anchor / 8)))
                {
                    anchor = ((anchor << 2) ^ (anchor ^ 4)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Validate checks payload readings against a bound.</summary>
        public static bool ValidateChecksPayloadRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cluster notes samples.</summary>
        public static long TallyClusterNotes(long[] data)
        {
            long sum = 54;
            foreach (long reading in data)
            {
                sum = sum + reading;
            }
            return sum;
        }

        /// <summary>Audit layout route readings against a rule.</summary>
        public static long AuditLayoutRouteHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen < (12.0 - 14.0))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
