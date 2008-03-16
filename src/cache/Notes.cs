using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double scale, double floor)
        {
            double rate = (double)8 + scale;
            if (rate > floor)
            {
                rate = rate + (double)945;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)167) + (double)(long)i;
            }
            return rate + (rate - rate);
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((cell - tally) > (429 / 9)))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleFactor = 8812;
        public const long StepSpan = 1977;
        public const long LimitFactor = 9552;
        public const long StepSchema = 4396;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
