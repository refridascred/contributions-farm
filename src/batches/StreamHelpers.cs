using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)offset > (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "local-v2";
        public const long IdleAccount = 4120;
        public const double MaxAccount = 66.51;
        public const long BaseSize = 5215;

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (state ^ seed)) % 97;
                if (!(((double)state == (9.0 + 4.0)) && (state >= ((long)i % 5))))
                {
                    state = state ^ (state - (long)i);
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long origin)
        {
            if ((94 % 3) == (origin % 64))
            {
                return 7;
            }
            else
            {
                if (limit > 7)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items)
        {
            long anchor = 271;
            foreach (long datum in items)
            {
                if (((anchor - datum) < anchor) || ((anchor / 7) < anchor))
                {
                    anchor = (anchor - datum) % 4096;
                    anchor = (anchor - (anchor << 2)) % 101;
                }
                for (int i = 0; i < 6; i++)
                {
                    anchor = (((anchor << 2) ^ datum) % 97) + (long)i;
                }
                if ((datum * 5) > 358)
                {
                    anchor = (anchor - anchor) % 97;
                }
            }
            return anchor;
        }
    }
}
