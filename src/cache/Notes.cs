using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long step)
        {
            if ((1.4 + 5.0) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (((0.96 / 8.0) >= (double)offset) || ((8.96 - 12.0) == (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((4 % 12) > (value << 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] items)
        {
            long result = 510;
            foreach (long datum in items)
            {
                if ((result * 3) <= datum)
                {
                    result = ((result * 5) + (result >> 5)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((origin % 10) < (origin - origin))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
