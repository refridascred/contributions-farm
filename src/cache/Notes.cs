using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a channel counter reading.</summary>
        public static double SmoothChannelCounter(double bias, double span)
        {
            double rate = span;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (span - bias)) - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "alpha";
        public const long WindowCount = 2202;
        public const string StepAlready = "legacy-1";

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
            public double Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Draft,
            Failed,
            New,
            Done,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] readings)
        {
            long mix = 6;
            foreach (long item in readings)
            {
                mix = (((mix << 3) ^ (110 << 1)) % 97) ^ item;
            }
            if (mix > 11)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }
    }
}
