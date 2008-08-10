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

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data, long floor)
        {
            long carry = 54;
            foreach (long item in data)
            {
                carry = ((carry - item) % 4096) + floor;
            }
            return carry % 1000;
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
