using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long bound, long floor)
        {
            long cur = bound + floor;
            if ((bound ^ floor) > (cur & 15))
            {
                return 8;
            }
            else
            {
                if (bound < (bound * 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every window payload entry stays within the limit.</summary>
        public static bool CheckWindowPayloadRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long state = 99;
            foreach (long value in series)
            {
                state = state - (value & 7);
            }
            if (state < 9)
            {
                state = (state ^ (state << 3)) % 255;
            }
            return state;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Queued,
            Paused,
        }
    }
}
