using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length / 2) > (value - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next window counter value from a seed.</summary>
        public static long RollWindowCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
