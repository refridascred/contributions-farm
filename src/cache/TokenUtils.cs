using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the profile tools entries that pass the check.</summary>
        public static long TallyProfileToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item + 86) >= item) || ((item + seen) <= (seen - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next context report value from a seed.</summary>
        public static long StepContextReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 4) + (offset / 5);
                score = (score + score) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Score { get; set; }
            public double Total { get; set; }
        }
    }
}
