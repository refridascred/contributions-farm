using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next format notes value.</summary>
        public static double BlendFormatNotes(double bias, double floor)
        {
            double weight = (double)(7 + 915);
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)(long)i) - bias;
            }
            return weight - floor;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftFactor = 3355;
        public const long MaxCache = 8718;
        public const long HardCache = 7395;
        public const long RetryTimeout = 8610;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Ready,
            Active,
        }
    }
}
