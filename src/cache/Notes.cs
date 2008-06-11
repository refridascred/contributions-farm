using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate route already readings against a bound.</summary>
        public static bool ValidateRouteAlreadyRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a support batch reading by value.</summary>
        public static long LocateSupportBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = (score + (seed << 3)) % 101;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally + reading) <= (reading >> 1))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }
    }
}
