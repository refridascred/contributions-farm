using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 8282;
        public const string HardScore = "stable-edge";
        public const long BurstRecord = 8444;

        /// <summary>Roll a command payload counter forward.</summary>
        public static long IterateCommandPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((double)(long)i > (5.0 * 0.8))
                {
                    sum = (sum + (floor - 95)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell & 255) > (cell & 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of contributi profile readings.</summary>
        public static long OverlapContributiProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two commits filter measurements.</summary>
        public static double SmoothCommitsFilter(double ratio, double offset)
        {
            double drift = (double)(759 + (-8));
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift + drift) + (double)(long)i) - ratio) + offset;
            }
            return drift - (double)790;
        }
    }
}
