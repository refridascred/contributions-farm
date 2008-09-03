using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings)
        {
            long sum = 84;
            foreach (long sample in readings)
            {
                sum = (sum - sample) % 255;
                if (!((sum ^ sample) == (long)readings.Length))
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum > 227)
            {
                sum = (sum + sum) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (4 <= (tally / 2))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
