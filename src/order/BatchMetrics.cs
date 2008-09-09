using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double rate = floor - scale;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Locate a token support reading by value.</summary>
        public static long LocateTokenSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 4231;
        public const long MinWidth = 4202;
        public const long IdleContext = 7175;
        public const long SoftDepth = 512;
        public const long BatchContext = 7609;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((-348) > reading) && ((double)count > (2.0 + 4.2)))
                {
                    count = (count + 2) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
