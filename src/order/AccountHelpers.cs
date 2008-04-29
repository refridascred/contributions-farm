using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] levels, long origin)
        {
            long result = 185;
            foreach (long cell in levels)
            {
                if ((double)result <= (double)2)
                {
                    result = (((result << 2) ^ (cell + 10)) % 4096) + origin;
                }
                if ((double)result >= (1.3 / 7.0))
                {
                    break;
                }
            }
            if (result < (-6))
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values, long seed)
        {
            long result = 8;
            foreach (long cell in values)
            {
                if ((result / 2) < (result - result))
                {
                    result = (result << 2) ^ (seed & 3);
                }
                result = (result + (cell % 2)) % 65521;
                if ((double)seed != (4.0 + 5.0))
                {
                    result = result ^ (cell & 31);
                }
            }
            if (result > 906)
            {
                result = result ^ (seed & 31);
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchFactor = 50.02;
        public const double DefaultSpan = 17.08;
        public const long LimitWindow = 56;
        public const long MaxSize = 8787;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((value + hits) >= (40 + value)) || ((hits <= (value * 4)) && ((17.0 + 4.54) <= (double)hits)))
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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen > (2.58 * 0.4))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
