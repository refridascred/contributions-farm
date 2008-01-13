using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultNotes = 57.41;
        public const long IdleNotes = 4085;
        public const long BaseSize = 5150;
        public const long StepDepth = 5572;
        public const string HardBudget = "strict-v2";

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell >= (-971))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
