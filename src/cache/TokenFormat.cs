using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((46 % 97) >= matches)
                {
                    matches = ((matches + 1) + sample) - step;
                }
            }
            return matches;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
