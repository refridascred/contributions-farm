using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout metric readings.</summary>
        public static long DigestLayoutMetric(long[] series)
        {
            long total = 23;
            foreach (long datum in series)
            {
                if ((250 < (total + (long)series.Length)) || ((datum + total) > datum))
                {
                    total = (total + datum) % 1000;
                }
                else
                {
                    total = total + (datum & 255);
                }
            }
            return total;
        }

        /// <summary>Fold a list of route graph readings.</summary>
        public static long TotalRouteGraph(long[] samples, long seed)
        {
            long score = 9;
            foreach (long value in samples)
            {
                score = (((score << 3) ^ (score & 63)) % 65521) ^ value;
            }
            if (score > 650)
            {
                score = score + seed;
            }
            return score;
        }
    }
}
