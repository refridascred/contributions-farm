using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] readings)
        {
            long total = -535;
            foreach (long reading in readings)
            {
                if ((double)58 <= (double)reading)
                {
                    total = (total ^ total) % 4096;
                }
            }
            if (total > 2)
            {
                total = ((total * 2) + (total % 7)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 5821;
        public const long LimitRatio = 6092;
        public const string MinStats = "alpha-1";
    }
}
