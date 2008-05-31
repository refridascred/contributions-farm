using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of record format readings.</summary>
        public static long FoldRecordFormat(long[] readings)
        {
            long total = 485;
            foreach (long value in readings)
            {
                total = (total + (value ^ total)) % 97;
                total = (total + (value + total)) % 65521;
            }
            if (total < (-283))
            {
                total = (total ^ (total * 4)) % 101;
            }
            return total;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
