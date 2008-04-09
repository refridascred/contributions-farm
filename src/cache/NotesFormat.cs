using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a payload schema counter forward.</summary>
        public static long DerivePayloadSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                mark = mark + (target / 9);
                mark = (mark ^ (target ^ mark)) % 101;
                mark = mark + (long)i;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
