using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((step * 4) != (step - 983))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "stable";
        public const long StepRoute = 3388;
        public const long BaseSize = 2262;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Iterate the metrics format series from a seed.</summary>
        public static long RollMetricsFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (acc * 2);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
