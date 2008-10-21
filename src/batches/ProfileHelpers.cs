using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Done,
            Closed,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry * 3) + (target ^ 622);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinTimeout = 5806;
        public const long CacheBatches = 7430;
        public const double DefaultBatches = 30.81;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7243;
        public const double IdleWindow = 79.01;
        public const string SoftRatio = "primary-v2";
        public const long StepWindow = 5054;
        public const double MinWindow = 30.11;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the contributi support entries that pass the check.</summary>
        public static long MeasureContributiSupportHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((8.1 - 4.5) > (double)bound)
                {
                    tally = (tally + 1) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
