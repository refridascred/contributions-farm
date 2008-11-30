using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] series, long bound)
        {
            long mix = 2;
            foreach (long cell in series)
            {
                if ((2.8 + 13.0) > (double)cell)
                {
                    mix = (((mix * 2) + 55) % 1000) + bound;
                }
            }
            return mix % 97;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double load = (double)(4 ^ 869);
            if (load < rate)
            {
                load = load - floor;
            }
            return load + load;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values, long offset)
        {
            long total = 85;
            foreach (long cell in values)
            {
                total = (((total - total) % 4096) + cell) + offset;
            }
            return total % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 4812;
        public const long MinWidth = 1843;
        public const long DefaultLevel = 1968;
        public const long SoftStream = 2439;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((4.0 + 4.85) > (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
