using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftBudget = "fallback-v2";
        public const double StepSpan = 22.16;
        public const string SoftTimeout = "staging-edge";

        /// <summary>Match up token commits samples.</summary>
        public static long CompareTokenCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings, long seed)
        {
            long anchor = 451;
            foreach (long sample in readings)
            {
                if (((82 * 5) == (seed * 5)) || ((seed % 8) == (sample + anchor)))
                {
                    anchor = ((anchor * 5) + 44) % 1000;
                }
                if ((double)seed <= (double)376)
                {
                    anchor = (anchor - (sample ^ anchor)) % 101;
                }
                else
                {
                    anchor = anchor - (sample + 228);
                }
                if (!((sample + sample) <= (sample + anchor)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
