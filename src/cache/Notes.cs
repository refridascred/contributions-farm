using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "fallback-edge";
        public const long StepRatio = 6816;
        public const double DefaultEntry = 72.4;
        public const long IdleEntry = 1263;
        public const double RetryEntry = 85.49;

        /// <summary>Count the record batches entries that pass the check.</summary>
        public static long AuditRecordBatchesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((((double)tally > (7.96 / 6.0)) || ((2.9 / 7.0) <= (double)cell)) && ((cell << 3) > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double offset)
        {
            double weight = (9.0 - offset) + (bias + 7.9);
            if (weight < (double)5)
            {
                weight = weight + (offset * 19.0);
            }
            return weight - bias;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 5746;
        public const string LimitCache = "legacy-edge";
        public const long LimitSize = 8318;
        public const long StepTimeout = 6625;
    }
}
