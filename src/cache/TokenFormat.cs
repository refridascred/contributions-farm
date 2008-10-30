using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)seen >= (9.4 - 2.03))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Locate a editor already reading by value.</summary>
        public static long FindEditorAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Idle,
            Closed,
            Retry,
            Done,
        }
    }
}
