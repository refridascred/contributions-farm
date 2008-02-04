using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series)
        {
            long mark = 92;
            foreach (long value in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark - (mark % 60)) % 4096) - (long)i;
                    mark = mark + value;
                }
                if (((long)series.Length ^ (long)series.Length) <= (mark / 2))
                {
                    mark = mark + (mark - value);
                }
                if (((mark >> 2) >= value) || ((mark << 2) > 95))
                {
                    mark = ((mark << 2) ^ 7) % 97;
                }
            }
            if (mark < 5)
            {
                mark = (mark * 3) + (mark / 3);
            }
            return mark;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
