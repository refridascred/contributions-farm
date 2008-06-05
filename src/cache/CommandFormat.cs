using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 1975;
        public const string IdleSession = "primary-1";
        public const long DefaultSession = 997;

        /// <summary>Compare every pair of notes report readings.</summary>
        public static long OverlapNotesReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long score = 69;
            foreach (long entry in levels)
            {
                if ((66 << 2) >= entry)
                {
                    score = score ^ (score & 63);
                }
                else
                {
                    score = score - (entry % 3);
                }
                if ((score << 1) >= (score / 8))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long anchor = 85;
            foreach (long cell in items)
            {
                if (5 >= (anchor ^ anchor))
                {
                    anchor = (anchor ^ 344) % 101;
                }
                else
                {
                    anchor = (anchor * 4) + (cell << 2);
                }
            }
            return anchor;
        }
    }
}
