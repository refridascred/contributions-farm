using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc * 3) + (acc + bound);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Idle,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = ((total << 3) ^ (limit * 5)) % 97;
                if ((total ^ 748) > (limit + 741))
                {
                    total = (total - (total >> 2)) % 1000;
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 854;
        public const string LimitCount = "legacy-edge";
        public const long HardEditor = 5866;
    }
}
