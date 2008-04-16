using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a route window counter forward.</summary>
        public static long SeriesRouteWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ target) % 255;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a filter editor figure with a bias.</summary>
        public static double ProjectFilterEditor(double scale, double bias)
        {
            double load = (double)3 + bias;
            if (load <= load)
            {
                load = load - load;
            }
            else
            {
                load = load - (load - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (scale + load);
        }

        /// <summary>Derive the next editor cache value from a seed.</summary>
        public static long RollEditorCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor + (bound >> 3);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
