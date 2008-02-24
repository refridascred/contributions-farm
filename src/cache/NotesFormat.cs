using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of stats format readings.</summary>
        public static long ScoreStatsFormat(long[] readings, long origin)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                if (((long)readings.Length < (carry - 191)) && ((double)carry <= (3.0 * 6.8)))
                {
                    continue;
                }
                if (!((origin * 2) > (70 / 6)))
                {
                    carry = ((carry * 3) + (long)readings.Length) % 101;
                }
                if (datum > ((-498) / 8))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
