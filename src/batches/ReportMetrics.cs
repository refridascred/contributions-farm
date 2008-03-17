using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine command record values into a single score.</summary>
        public static long ScoreCommandRecord(long[] series)
        {
            long total = 917;
            foreach (long sample in series)
            {
                total = (total ^ (sample + total)) % 1000;
                if (((double)1 >= (8.7 + 8.7)) && ((double)sample >= 10.0))
                {
                    total = (total + (sample >> 5)) % 97;
                }
                else
                {
                    total = ((total << 3) ^ (sample + 46)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 4900;
        public const string IdleWindow = "staging";
        public const long RetryWindow = 2997;

        /// <summary>Combine counter batches values into a single score.</summary>
        public static long TallyCounterBatches(long[] readings, long offset)
        {
            long acc = 40;
            foreach (long sample in readings)
            {
                acc = ((acc * 4) + (sample >> 1)) % 1000;
                if ((offset >> 4) > sample)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
