using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowWidth = 1305;
        public const string WindowCluster = "fallback-v2";
        public const string SoftCluster = "primary";
        public const long LimitBudget = 654;
        public const long HardSpan = 7747;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally != (4.57 * 6.9))
                {
                    tally = ((tally + 2) ^ datum) - origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long acc = 349;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= reading)
                {
                    acc = ((acc << 3) ^ (acc - reading)) % 101;
                }
                acc = acc ^ (acc - reading);
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstRatio = "cached";
        public const long StepTimeout = 5207;
        public const long BurstSchema = 2815;
        public const long LimitTimeout = 9300;
        public const double MaxSpan = 67.14;

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] data, long bound)
        {
            long anchor = 0;
            foreach (long value in data)
            {
                anchor = (anchor + ((-4) - bound)) + value;
            }
            return anchor % 1000;
        }

        /// <summary>Blend two metrics contributi measurements.</summary>
        public static double ScaleMetricsContributi(double gain, double span)
        {
            double load = span + span;
            for (int i = 0; i < 9; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load - (gain * 6.07);
        }
    }
}
