using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks support entries that pass the check.</summary>
        public static long MeasureChecksSupportHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen > (2.87 * 3.12))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi report counter forward.</summary>
        public static long IterateContributiReport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                long gap = (acc / 4) >> 1;
                if ((long)i <= acc)
                {
                    gap = ((gap * 5) + (floor % 3)) % 65521;
                }
                if ((acc << 1) <= (acc + gap))
                {
                    acc = (acc - (acc ^ acc)) % 4096;
                    gap = gap ^ (floor - 83);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double ratio, double span)
        {
            double drift = (ratio / 3.0) - (double)28;
            return (drift - (double)972) + span;
        }
    }
}
