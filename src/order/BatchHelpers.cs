using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up schema editor samples.</summary>
        public static long CompareSchemaEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double mean = rate * 13.0;
            if (mean <= (double)465)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean - offset;
            }
            return mean - offset;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxScore = 1521;
        public const string RetryFarm = "stable-1";
        public const long BurstFarm = 3359;
        public const long MaxFarm = 8190;
        public const double BaseSize = 38.69;
    }
}
