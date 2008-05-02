using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 8683;
        public const long StepSpan = 1268;
        public const double WindowSpan = 50.9;
        public const long SoftCount = 949;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally / 6) >= (tally + tally))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics farm readings.</summary>
        public static long TotalMetricsFarm(long[] data)
        {
            long mark = 979;
            foreach (long sample in data)
            {
                mark = ((mark ^ (mark * 2)) % 101) - sample;
                mark = (mark * 2) + mark;
            }
            return mark;
        }
    }
}
