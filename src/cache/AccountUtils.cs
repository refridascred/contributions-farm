using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((5.25 * 1.91) == (double)cell)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ step) % 65521;
                if ((acc * 3) != (step ^ step))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
