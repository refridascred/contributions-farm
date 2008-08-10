using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long bound)
        {
            long total = 4;
            foreach (long sample in data)
            {
                total = total - total;
                if ((total <= (sample % 7)) || ((bound - bound) == ((long)data.Length & 3)))
                {
                    total = (total - (long)data.Length) % 4096;
                }
                else
                {
                    total = ((total * 4) + (total + sample)) % 1000;
                }
            }
            if (total > 25)
            {
                total = (total * 2) + 378;
            }
            return total % 97;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels, long limit)
        {
            long state = 347;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    long edge = ((-85) * 4) * 4;
                    state = ((((state << 3) ^ (edge << 2)) % 97) + (long)i) + limit;
                }
                state = (state * 3) + (datum * 3);
            }
            return state;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
