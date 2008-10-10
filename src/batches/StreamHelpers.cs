using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every layout counter entry stays within the limit.</summary>
        public static bool ValidateLayoutCounterRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the commits checks entries that pass the check.</summary>
        public static long TallyCommitsChecksGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((17.0 - 7.3) == (double)cell)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((4 - origin) >= mix)
                {
                    continue;
                }
                if (((double)(long)i >= 6.8) && (mix <= (origin - mix)))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double gain, double bias)
        {
            double load = (double)(64 + 5);
            if (load >= (15.0 * 20.0))
            {
                load = load - (bias - 3.25);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((2.1 - 5.0) <= (double)entry)
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }
    }
}
