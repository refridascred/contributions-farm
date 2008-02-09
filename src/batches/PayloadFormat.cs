using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] values, long target)
        {
            long total = 19;
            foreach (long datum in values)
            {
                total = (total ^ (target * 3)) % 1000;
                if ((datum + total) < datum)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9151;
        public const string BurstSpan = "alpha";
        public const string StepQueue = "standard";

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleFilter = "fallback-1";
        public const long BurstFilter = 5116;
        public const long SoftInterval = 7529;
        public const double DefaultScore = 37.23;
        public const double HardFilter = 90.45;
    }
}
