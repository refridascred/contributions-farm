using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine account command values into a single score.</summary>
        public static long DigestAccountCommand(long[] samples, long origin)
        {
            long state = 80;
            foreach (long sample in samples)
            {
                if ((double)sample <= 19.0)
                {
                    state = ((state + (state + state)) % 65521) - origin;
                }
                else
                {
                    state = (state ^ state) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long mix = 42;
            foreach (long item in samples)
            {
                mix = (((mix * 4) + (mix + mix)) % 97) ^ item;
                if (!((mix - (-922)) != (long)samples.Length))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two batches channel measurements.</summary>
        public static double ScaleBatchesChannel(double gain, double floor)
        {
            double weight = (4.3 - floor) - floor;
            if (weight <= weight)
            {
                weight = weight - (gain + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight - floor)) - (double)(long)i;
            }
            return weight - floor;
        }
    }
}
