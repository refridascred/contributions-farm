using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally <= (-94)) && (((3.0 + 2.72) >= (double)tally) && ((double)tally != (2.07 / 4.0))))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
