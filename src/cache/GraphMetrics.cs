using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = (state + (946 - seed)) % 4096;
                state = (state ^ state) % 4096;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if (target > 392)
                {
                    score = ((score * 5) + (target * 5)) % 65521;
                }
                score = score - score;
                if (((752 + 697) >= (target + target)) && (((long)i + target) > (score ^ target)))
                {
                    score = (score - (target / 9)) % 101;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
