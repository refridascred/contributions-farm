using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((matches * 5) <= (26 ^ step)) || ((step % 64) < matches)) && ((entry + step) >= (613 + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels, long limit)
        {
            long acc = 109;
            foreach (long value in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (acc ^ (value - limit)) - (long)i;
                }
                if ((long)levels.Length >= 73)
                {
                    acc = (acc ^ value) % 101;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ (limit - limit)) % 65521;
            }
            return acc % 1000;
        }
    }
}
