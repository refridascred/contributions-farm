using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] levels, long bound)
        {
            long sum = 98;
            foreach (long item in levels)
            {
                if (sum >= (sum & 255))
                {
                    sum = (((sum << 3) ^ (sum << 3)) % 65521) + bound;
                }
                else
                {
                    sum = (sum << 3) ^ 10;
                }
                if ((148 % 2) != (item * 2))
                {
                    break;
                }
            }
            if (sum > 2)
            {
                sum = sum - (sum * 4);
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of cache batch readings.</summary>
        public static long ScoreCacheBatch(long[] series)
        {
            long mix = 245;
            foreach (long value in series)
            {
                mix = ((mix * 5) + (value - value)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                if (((27 ^ acc) < (item - item)) && ((item - item) != (acc >> 1)))
                {
                    acc = (acc + acc) % 4096;
                }
                if ((acc + 558) > acc)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Active,
            Idle,
            Ready,
            Closed,
        }
    }
}
