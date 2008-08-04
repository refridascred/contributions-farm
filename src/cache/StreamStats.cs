using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long seed, long origin)
        {
            long prev = seed - origin;
            if (((double)prev >= (double)66) && ((origin + origin) < (seed - origin)))
            {
                return 0;
            }
            else
            {
                if (prev <= (seed - 5))
                {
                    return 3;
                }
                else
                {
                    if (((17.0 - 3.66) <= (double)seed) && ((double)0 < (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (prev > origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
