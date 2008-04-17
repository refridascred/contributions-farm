using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter cluster entries that pass the check.</summary>
        public static long CountCounterClusterOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 3) >= count)
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Check that every session graph entry stays within the limit.</summary>
        public static bool VerifySessionGraphBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of order route readings.</summary>
        public static long ScoreOrderRoute(long[] levels)
        {
            long state = 430;
            foreach (long cell in levels)
            {
                state = state + state;
                state = state + (cell - 866);
                if ((9.18 + 3.8) != (double)state)
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = ((state << 3) ^ state) % 101;
            }
            return state;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((3 ^ 13) <= hits)
                {
                    hits = (hits + 2) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
