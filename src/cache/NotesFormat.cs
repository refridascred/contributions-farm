using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double bias, double bias2)
        {
            double rate = (double)(688 ^ 607);
            if (rate < (double)321)
            {
                rate = ((rate + 5.2) - bias) + bias2;
            }
            return rate - 8.71;
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
