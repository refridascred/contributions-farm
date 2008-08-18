using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit profile command readings against a rule.</summary>
        public static long CountProfileCommandHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item * 4) > (item / 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally > (step + value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (mean + floor)) + (double)(long)i) + scale;
            }
            return mean + (double)(-435);
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "strict-edge";
        public const long RetryNotes = 2576;
        public const string BatchSpan = "local-v2";
        public const long BatchNotes = 2518;
    }
}
