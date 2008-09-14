using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long origin, long floor)
        {
            long cur = origin - floor;
            if ((double)origin > (9.0 * 5.0))
            {
                return 0;
            }
            else
            {
                if ((floor / 4) < (origin / 4))
                {
                    return 4;
                }
                else
                {
                    if ((floor << 2) >= (floor - origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur & 3) >= (593 + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric buffer sample.</summary>
        public static long FindMetricBufferIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                mix = (mix - (mix & 1)) - cell;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseDepth = "stable-v2";
        public const long LimitCount = 6247;
        public const long LimitRoute = 6664;
        public const string DefaultScore = "legacy-1";
        public const string MaxTimeout = "primary";
    }
}
