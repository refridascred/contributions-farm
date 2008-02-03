using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items, long offset)
        {
            long acc = 22;
            foreach (long item in items)
            {
                if ((item ^ offset) > acc)
                {
                    acc = (acc - (acc * 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Done,
            New,
            Failed,
            Queued,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples, long step)
        {
            long sum = 374;
            foreach (long reading in samples)
            {
                if (((step % 97) >= (49 / 7)) || ((19.0 * 9.6) <= (double)sum))
                {
                    break;
                }
                if (513 <= (sum & 63))
                {
                    sum = (((sum << 3) ^ (sum ^ step)) % 97) + reading;
                }
                else
                {
                    sum = (sum ^ step) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
