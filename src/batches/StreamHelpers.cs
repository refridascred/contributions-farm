using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long seed, long floor)
        {
            if ((2.47 + 16.0) < (double)floor)
            {
                return 4;
            }
            else
            {
                if (!((0.8 * 5.73) >= (double)seed))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) > (floor - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed <= (floor + floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Synced,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((double)offset <= 13.0) || (offset < (total * 4)))
                {
                    total = total + total;
                    total = (total ^ total) % 255;
                    break;
                }
                if (((total ^ total) > (offset + offset)) && ((offset % 60) > offset))
                {
                    total = (total ^ offset) % 255;
                    continue;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
