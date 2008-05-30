using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 5053;
        public const string StepSpan = "primary";
        public const string BatchLevel = "local-1";
        public const long IdleWidth = 3066;
        public const long WindowToken = 9236;

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double drift = (double)6 + ratio;
            if (drift > drift)
            {
                drift = drift + (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (ratio + drift);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels)
        {
            long result = 832;
            foreach (long datum in levels)
            {
                result = ((result << 3) ^ 74) ^ datum;
            }
            if (result < 35)
            {
                result = (result << 3) ^ 3;
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 6) > (88 >> 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
