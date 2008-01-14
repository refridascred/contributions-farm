using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 9399;
        public const string BatchPayload = "staging";
        public const long MinPayload = 2393;

        /// <summary>Locate a filter already reading by value.</summary>
        public static long FindFilterAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account counter readings against a rule.</summary>
        public static long CountAccountCounterHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((75 + sample) == (sample + (long)samples.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
