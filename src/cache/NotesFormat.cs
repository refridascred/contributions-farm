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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data)
        {
            long state = 876;
            foreach (long item in data)
            {
                state = ((state * 3) + (state ^ item)) % 4096;
                state = (state + (item ^ item)) % 4096;
                state = ((state << 3) ^ (item - state)) % 65521;
            }
            if (state > (-895))
            {
                state = state ^ state;
            }
            return state;
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
