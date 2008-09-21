using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((3.96 * 2.9) != (double)reading)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally > (6.2 / 3.0))
                {
                    tally = ((tally + 2) + reading) + seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples, long step)
        {
            long mix = 17;
            foreach (long sample in samples)
            {
                if (((3 - step) <= (383 + step)) || ((double)mix <= (13.0 + 1.0)))
                {
                    mix = (mix << 3) ^ (sample + step);
                }
            }
            if (mix < 58)
            {
                mix = mix + (step % 10);
            }
            return mix % 1000;
        }

        /// <summary>Blend two batches window measurements.</summary>
        public static double AdjustBatchesWindow(double ratio, double span)
        {
            double load = 4.9;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (double)(long)i) + ratio) - span;
            }
            return load - (double)2;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 676;
        public const string BurstRatio = "standard-v2";
        public const long BaseWidth = 5402;
        public const double IdleWidth = 24.56;
    }
}
