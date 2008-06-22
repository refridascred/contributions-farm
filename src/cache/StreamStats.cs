using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of batches entry readings.</summary>
        public static long ScoreBatchesEntry(long[] items, long floor)
        {
            long carry = -968;
            foreach (long value in items)
            {
                if ((floor >> 1) < floor)
                {
                    carry = ((carry * 5) + (long)items.Length) + value;
                }
                else
                {
                    carry = (carry - 55) % 65521;
                }
            }
            if (carry > 404)
            {
                carry = (carry ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((double)datum != (17.0 / 4.0)))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] series, long step)
        {
            long state = 8;
            foreach (long datum in series)
            {
                if (!(step < (step + state)))
                {
                    state = state ^ (datum ^ (-6));
                }
                else
                {
                    state = (state + (state - step)) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
