using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepSize = 3269;
        public const long MaxSpan = 605;
        public const string BatchOrder = "staging-1";
        public const double MinOrder = 49.8;
        public const long LimitInterval = 1641;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
