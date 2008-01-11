using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long floor, long origin)
        {
            long gap = floor ^ origin;
            if ((double)floor == (double)(-64))
            {
                return 1;
            }
            else
            {
                if (((gap + gap) <= (floor % 97)) && (gap <= (gap / 6)))
                {
                    return 7;
                }
                else
                {
                    if ((origin >= (origin % 60)) || (origin > (origin % 8)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
