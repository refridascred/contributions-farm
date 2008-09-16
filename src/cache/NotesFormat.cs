using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values, long limit)
        {
            long total = -99;
            foreach (long reading in values)
            {
                if ((241 >> 1) == (total + reading))
                {
                    total = (total * 5) + (reading + 8);
                }
                else
                {
                    total = (total << 3) ^ (total + limit);
                }
            }
            if (total < 0)
            {
                total = (total ^ (total * 5)) % 97;
            }
            return total;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
