using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the stream editor series from a seed.</summary>
        public static long StepStreamEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate githubfarm entry samples.</summary>
        public static long WeighGithubfarmEntry(long[] items, long bound)
        {
            long mark = 6;
            foreach (long cell in items)
            {
                mark = (mark * 3) + (cell / 9);
                if (bound <= (cell << 2))
                {
                    mark = (mark << 2) ^ (bound + mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Locked,
            Failed,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + matches) >= (823 - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
