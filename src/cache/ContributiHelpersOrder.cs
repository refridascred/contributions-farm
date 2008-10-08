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

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total ^ (0 - (long)i)) % 255) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
