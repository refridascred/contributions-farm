using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((94 * 2) >= ((long)data.Length - (long)data.Length)))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a buffer account counter forward.</summary>
        public static long IterateBufferAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((total % 97) > total)
                {
                    total = ((total << 3) ^ (limit % 12)) % 4096;
                }
                total = total ^ ((long)i + total);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
