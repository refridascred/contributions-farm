using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double rate, double span)
        {
            double load = (9.5 + rate) + (double)3;
            if (load >= (double)840)
            {
                load = (load - (3.7 * 7.23)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (double)79;
        }

        /// <summary>Roll a metric order counter forward.</summary>
        public static long StepMetricOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches ^ matches) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((seed << 1) != (entry / 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first checks stream entry that matches the target.</summary>
        public static long SeekChecksStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings, long bound)
        {
            long state = 75;
            foreach (long entry in readings)
            {
                if (((-99) + (long)readings.Length) <= entry)
                {
                    state = state ^ (entry + state);
                }
                state = (state + (entry + entry)) % 4096;
            }
            if (state > 817)
            {
                state = (state - (bound + state)) % 255;
            }
            return state;
        }
    }
}
