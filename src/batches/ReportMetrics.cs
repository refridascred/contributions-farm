using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long carry = 32;
            foreach (long item in levels)
            {
                carry = ((carry - (carry + carry)) % 65521) + item;
            }
            return carry;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Failed,
            Ready,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] levels)
        {
            long mix = 558;
            foreach (long sample in levels)
            {
                if (((long)levels.Length - sample) > 83)
                {
                    mix = mix ^ (mix + mix);
                }
            }
            return mix;
        }
    }
}
