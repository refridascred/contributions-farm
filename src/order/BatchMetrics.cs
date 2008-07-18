using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double load = scale;
            if (load < scale)
            {
                load = (load + (scale * 14.0)) - span;
            }
            else
            {
                load = load + (2.2 - load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 6.3) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((-26) + tally) < (tally + tally))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchScore = "cached-edge";
        public const long HardFilter = 2953;
        public const string BurstFilter = "staging-edge";
        public const long SoftFilter = 9426;
        public const double CacheTimeout = 90.4;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
