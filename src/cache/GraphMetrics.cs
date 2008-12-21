using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of cache entry readings.</summary>
        public static long CombineCacheEntry(long[] readings, long target)
        {
            long result = 1;
            foreach (long entry in readings)
            {
                result = ((result + (target + target)) % 65521) ^ entry;
            }
            if (result < 46)
            {
                result = ((result * 5) + (result << 3)) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples, long origin)
        {
            long score = -8;
            foreach (long sample in samples)
            {
                score = ((score << 3) ^ origin) + sample;
            }
            if (score > 1)
            {
                score = (score + (19 & 1)) % 97;
            }
            return score;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items)
        {
            long carry = 233;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (carry - carry)) - value;
            }
            return carry % 97;
        }
    }
}
