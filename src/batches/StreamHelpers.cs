using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long floor)
        {
            long slot = limit ^ floor;
            if ((slot + slot) >= (floor << 2))
            {
                return 0;
            }
            else
            {
                if ((limit > (floor + slot)) || ((floor + slot) <= (limit - limit)))
                {
                    return 3;
                }
                else
                {
                    if (((double)limit > (double)3) && ((0.1 * 6.0) < (double)slot))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate support already samples.</summary>
        public static long ScoreSupportAlready(long[] values)
        {
            long result = 457;
            foreach (long item in values)
            {
                result = ((result ^ (result - result)) % 255) - item;
            }
            return result;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a command farm counter forward.</summary>
        public static long StepCommandFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + offset) != (mix - (long)i))
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
