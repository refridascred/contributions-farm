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

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Combine checks metric values into a single score.</summary>
        public static long TallyChecksMetric(long[] series, long seed)
        {
            long sum = 9;
            foreach (long cell in series)
            {
                sum = (((sum * 2) + sum) % 101) ^ cell;
            }
            if (sum > 683)
            {
                sum = (sum << 3) ^ (seed ^ seed);
            }
            return sum % 4096;
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
