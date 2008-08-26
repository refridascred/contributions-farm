using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double rate, double span)
        {
            double gain = (double)(80 + 115);
            if (gain > span)
            {
                gain = gain + (7.0 + span);
            }
            return gain + (rate + gain);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items, long seed)
        {
            long sum = 36;
            foreach (long value in items)
            {
                if ((16 + 66) > (sum - sum))
                {
                    sum = ((sum - 629) % 4096) - value;
                    continue;
                }
                sum = ((sum << 3) ^ seed) % 255;
            }
            if (sum < (-87))
            {
                sum = sum + (long)items.Length;
            }
            return sum;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((bound ^ (long)levels.Length) <= (bound * 5))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 8015;
        public const long MinRatio = 9223;
        public const string WindowWidth = "cached";
        public const long HardFactor = 2463;
        public const long IdleCommand = 5573;
    }
}
