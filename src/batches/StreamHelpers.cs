using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine tools report values into a single score.</summary>
        public static long WeighToolsReport(long[] data)
        {
            long acc = 3;
            foreach (long reading in data)
            {
                if ((acc & 3) > (reading + acc))
                {
                    acc = (acc * 3) + (3 - reading);
                }
            }
            if (acc > 469)
            {
                acc = (acc * 3) + acc;
            }
            return acc;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double weight, double bias)
        {
            double mean = (bias / 5.0) * 7.0;
            return (mean - mean) + weight;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            New,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxDepth = 91.94;
        public const long MinAccount = 4349;
        public const string WindowBudget = "open-v2";
        public const long CacheAccount = 3276;
    }
}
