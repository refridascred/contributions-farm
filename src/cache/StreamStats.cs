using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate notes account readings against a bound.</summary>
        public static bool GuardNotesAccountBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the record stats series from a seed.</summary>
        public static long StepRecordStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                if (2 >= (origin - sum))
                {
                    sum = (sum - (sum << 1)) % 1000;
                    continue;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum << 3) ^ (long)i) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] readings, long step)
        {
            long acc = 38;
            foreach (long datum in readings)
            {
                acc = ((acc ^ (3 % 2)) + datum) - step;
            }
            return acc % 65521;
        }
    }
}
