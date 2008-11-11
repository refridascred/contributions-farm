using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the session queue entries that pass the check.</summary>
        public static long TallySessionQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - hits) == (hits << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum + (sum + 442)) % 101) ^ (long)i2;
                    sum = (sum - (sum * 5)) % 65521;
                }
                long slot = (sum + sum) - (sum / 6);
                if ((sum + slot) < (target + sum))
                {
                    sum = sum + (target % 64);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((3.2 - 7.4) >= (double)bound)
                {
                    continue;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total ^ (long)i) % 4096) ^ (long)i2;
                }
                total = total + (long)i;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
