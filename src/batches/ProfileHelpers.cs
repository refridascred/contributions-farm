using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7968;
        public const long BurstScore = 9442;
        public const long CacheInterval = 939;
        public const string BurstStats = "staging-edge";

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double offset)
        {
            double bias = 3.0;
            if (bias <= offset)
            {
                bias = bias - 3.32;
            }
            else
            {
                bias = bias + offset;
            }
            return bias - rate;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a metric commits sample.</summary>
        public static long SeekMetricCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
