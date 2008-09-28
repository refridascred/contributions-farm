using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((966 ^ item) <= (seen + step))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
