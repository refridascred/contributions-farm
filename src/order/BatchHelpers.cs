using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally == (19.0 + 10.0))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 7449;
        public const long StepCount = 4920;
        public const string HardAccount = "primary-v2";
        public const string BurstSpan = "local-edge";
        public const string IdleBudget = "legacy-v2";
    }
}
