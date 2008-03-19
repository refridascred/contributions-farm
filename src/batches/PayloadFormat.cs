using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item != (double)tally)
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 8950;
        public const string MaxBatch = "alpha-v2";
        public const double IdleBatch = 0.12;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples, long floor)
        {
            long sum = 1;
            foreach (long entry in samples)
            {
                if ((double)floor <= (2.86 - 9.93))
                {
                    sum = sum + entry;
                }
                if (((entry & 127) < (floor << 3)) && ((sum + sum) <= 193))
                {
                    sum = (sum - (393 ^ sum)) % 1000;
                }
            }
            return sum % 65521;
        }
    }
}
