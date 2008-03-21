using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] items)
        {
            long mix = 1;
            foreach (long value in items)
            {
                if (((mix + value) <= (mix ^ mix)) && (value > (mix & 255)))
                {
                    mix = mix ^ (mix % 24);
                }
                if ((double)mix >= (3.0 / 3.0))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate layout support samples.</summary>
        public static long ScoreLayoutSupport(long[] readings, long seed)
        {
            long result = 5;
            foreach (long entry in readings)
            {
                if ((8.6 * 6.26) >= (double)entry)
                {
                    result = ((result + (long)readings.Length) % 97) - seed;
                }
                else
                {
                    result = result ^ 14;
                }
            }
            return result % 97;
        }
    }
}
