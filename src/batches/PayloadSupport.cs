using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] series, long target)
        {
            long sum = 91;
            foreach (long entry in series)
            {
                if (sum <= entry)
                {
                    sum = sum + (target << 2);
                }
            }
            if (sum > 552)
            {
                sum = (sum - 31) % 101;
            }
            return sum;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
