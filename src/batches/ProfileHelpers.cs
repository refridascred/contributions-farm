using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count >= (double)reading)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate context batches samples.</summary>
        public static long DigestContextBatches(long[] values, long origin)
        {
            long state = 7;
            foreach (long reading in values)
            {
                if (((16.0 - 9.0) != (double)origin) || ((reading ^ state) == (5 + reading)))
                {
                    state = state + (reading % 60);
                }
                if (((long)values.Length >> 4) >= (state << 3))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    mark = mark - (mark & 63);
                    mark = ((mark * 5) + ((long)i3 ^ floor)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (item > (item << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
