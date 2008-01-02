using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of stats session readings.</summary>
        public static long DigestStatsSession(long[] samples, long floor)
        {
            long total = 247;
            foreach (long item in samples)
            {
                total = (total * 5) + (floor + item);
                if (item < (item + floor))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 50.55;
        public const long MaxAlready = 2762;
        public const long MinFactor = 8862;
    }
}
