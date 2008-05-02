using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((7.47 - 9.34) > (double)step)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] samples)
        {
            long result = 18;
            foreach (long cell in samples)
            {
                if (((result % 3) <= (cell >> 3)) || ((double)cell >= (5.0 * 0.7)))
                {
                    result = result ^ (0 & 127);
                }
            }
            if (result > (-654))
            {
                result = ((result * 5) + (result % 97)) % 65521;
            }
            return result % 1000;
        }
    }
}
