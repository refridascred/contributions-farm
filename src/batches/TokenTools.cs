using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double span)
        {
            double bias = (double)(96 / 6);
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (weight * 18.0)) + (double)(long)i) + span;
            }
            return bias - (double)230;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardBuffer = "staging-edge";
        public const long MinBudget = 5297;
        public const string IdleBuffer = "stable-edge";
        public const long HardSize = 2355;
        public const long BatchBudget = 3863;

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
