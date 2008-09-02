using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + (origin - (-824))) % 101;
                if (17.0 > (double)total)
                {
                    total = (total + (long)i) % 65521;
                }
                else
                {
                    total = (total ^ (total + (-99))) % 65521;
                }
                total = ((total << 3) ^ (total + total)) % 255;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 4.87;
        public const long MinRatio = 6678;
        public const string MaxFormat = "fallback-v2";
        public const string LimitDepth = "local-1";

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
