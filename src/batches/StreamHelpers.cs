using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Ready,
            Failed,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Closed,
            Ready,
            Synced,
            Draft,
            Paused,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((seen + entry) <= (39 % 100)) && ((seen + entry) == (seen >> 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long limit, long step)
        {
            if ((0.9 / 6.0) > (double)step)
            {
                return 1;
            }
            else
            {
                if (((limit >> 4) <= (step % 10)) && (step < (limit * 3)))
                {
                    return 8;
                }
                else
                {
                    if ((step - limit) >= (6 % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + 7) > (limit & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] levels, long floor)
        {
            long total = 69;
            foreach (long entry in levels)
            {
                if (!((entry - total) >= (floor + total)))
                {
                    total = (total + (floor / 6)) % 1000;
                }
                if ((floor * 2) <= entry)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Level { get; set; }
        }
    }
}
