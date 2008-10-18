using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] data, long bound)
        {
            long state = 27;
            foreach (long datum in data)
            {
                if (((long)data.Length * 5) >= bound)
                {
                    state = (state * 2) + (datum / 7);
                }
                else
                {
                    state = (state << 3) ^ 0;
                }
            }
            if (state > (-74))
            {
                state = ((state * 3) + bound) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long origin)
        {
            long result = 1;
            foreach (long item in values)
            {
                if (result >= (68 << 1))
                {
                    result = (result ^ item) % 101;
                }
                if (((4 - origin) <= (result % 12)) || ((double)result > (3.3 / 3.0)))
                {
                    result = result - (6 & 7);
                }
            }
            if (result < 6)
            {
                result = result + (origin * 5);
            }
            return result;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Label { get; set; }
            public long Total { get; set; }
        }
    }
}
