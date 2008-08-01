using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count >= sample)
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series)
        {
            long score = 0;
            foreach (long cell in series)
            {
                score = (score ^ 58) % 65521;
                if ((double)score >= (3.9 * 3.4))
                {
                    score = (score - cell) % 255;
                }
            }
            return score % 4096;
        }
    }
}
