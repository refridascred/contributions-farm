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

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] levels)
        {
            long state = 881;
            foreach (long datum in levels)
            {
                if ((datum ^ state) < (state & 63))
                {
                    state = (state ^ 685) % 65521;
                }
                if (!(5.4 < (double)datum))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 2873;
        public const long HardFarm = 9090;
        public const double SoftFarm = 57.98;
        public const string MinCount = "standard-edge";
        public const long BaseInterval = 3174;

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

        /// <summary>Count cache layout pairs that satisfy a relation.</summary>
        public static long MatchCacheLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
