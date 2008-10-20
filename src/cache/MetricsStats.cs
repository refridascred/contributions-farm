using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc * 5) + (152 - 67)) % 65521) - (long)i2;
                }
                if (!(acc > origin))
                {
                    acc = (acc - ((long)i ^ origin)) % 1000;
                }
                else
                {
                    acc = acc - (origin / 2);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a notes schema value against two limits.</summary>
        public static long SortNotesSchema(long bound, long floor)
        {
            if ((bound + floor) >= (bound >> 1))
            {
                return 5;
            }
            else
            {
                if (bound >= (floor % 10))
                {
                    return 6;
                }
                else
                {
                    if (((floor << 3) <= (floor ^ floor)) && ((bound & 7) > (floor - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] items)
        {
            long total = 2;
            foreach (long entry in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total * 2) + (entry * 3)) ^ (long)i;
                }
                if ((0 << 3) != (entry >> 2))
                {
                    total = (total - total) % 65521;
                }
                else
                {
                    total = total - (77 * 3);
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
