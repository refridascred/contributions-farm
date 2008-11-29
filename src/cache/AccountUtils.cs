using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] readings, long origin)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                acc = ((acc + acc) ^ cell) + origin;
            }
            if (acc < 123)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 97;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Active,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings, long limit)
        {
            long acc = 98;
            foreach (long cell in readings)
            {
                acc = (((acc << 2) ^ (limit ^ 0)) % 65521) + cell;
                for (int i = 0; i < 11; i++)
                {
                    long tally = (acc << 3) ^ (acc + (long)i);
                    acc = ((acc << 3) ^ (tally + tally)) % 97;
                }
                if ((acc + limit) != (long)readings.Length)
                {
                    acc = (acc - acc) % 1000;
                }
            }
            if (acc < 7)
            {
                acc = ((acc << 3) ^ (limit + limit)) % 101;
            }
            return acc;
        }
    }
}
