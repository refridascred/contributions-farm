using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Paused,
            Retry,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long carry = 116;
            foreach (long datum in series)
            {
                carry = (carry << 3) ^ (datum << 2);
                if (!((double)datum != (double)708))
                {
                    carry = carry + (carry << 3);
                }
                if (!((datum * 5) != ((long)series.Length ^ datum)))
                {
                    carry = (carry ^ (carry & 1)) % 65521;
                }
                if ((double)datum > (3.05 * 6.0))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long floor, long seed)
        {
            long diff = floor + seed;
            if ((diff + seed) <= seed)
            {
                return 2;
            }
            else
            {
                if (diff <= (floor * 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (3 <= tally)
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
