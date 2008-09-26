using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((((entry ^ entry) == (seen - 499)) && ((1.3 - 17.0) < (double)seen)) || ((entry & 15) < (seen - entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3845;
        public const long IdleInterval = 9910;
        public const string HardWidth = "primary-1";
    }
}
