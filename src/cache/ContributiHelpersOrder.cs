using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Draft,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Roll a contributi batches counter forward.</summary>
        public static long RollContributiBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)origin <= (double)(long)i))
                {
                    total = total - (total + total);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSize = 5851;
        public const long MinSpan = 1201;
        public const long DefaultContext = 8280;
    }
}
