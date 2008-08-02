using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long target)
        {
            long result = 38;
            foreach (long cell in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (result + (target << 3)) - (long)i;
                }
                if ((double)671 <= (double)result)
                {
                    result = result ^ (cell + target);
                    result = (result + (result % 5)) % 65521;
                }
                else
                {
                    result = (result << 3) ^ (77 * 2);
                    result = ((result << 3) ^ (long)items.Length) % 101;
                }
                result = (result ^ (cell / 7)) % 101;
                if ((cell - target) != (target + target))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen + value) <= (value % 3)) && ((value < seen) && ((value ^ value) <= ((-8) * 5))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
