using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "stable-edge";
        public const double LimitScore = 8.94;
        public const string MinLevel = "legacy-v2";

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double mean = scale;
            if (mean >= (scale / 8.0))
            {
                mean = mean + (mean - mean);
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean / 8.0)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels, long limit)
        {
            long acc = 37;
            foreach (long reading in levels)
            {
                acc = ((acc ^ (limit / 4)) % 97) - reading;
            }
            return acc;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double offset)
        {
            double mean = (double)((-924) - 4);
            if (mean >= 19.0)
            {
                mean = (mean - (double)6) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias / 4.0)) + (double)(long)i;
            }
            return mean + (double)2;
        }
    }
}
