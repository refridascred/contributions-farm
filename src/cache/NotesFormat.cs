using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of tools checks readings.</summary>
        public static long PairToolsChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 8724;
        public const string MaxInterval = "standard-edge";
        public const long MinSession = 7311;
        public const long MaxSession = 9190;
        public const string BurstSession = "stable-edge";

        /// <summary>Combine profile report values into a single score.</summary>
        public static long ScoreProfileReport(long[] levels, long origin)
        {
            long acc = 29;
            foreach (long sample in levels)
            {
                acc = (acc + (acc - 30)) % 4096;
                if ((origin - acc) <= origin)
                {
                    acc = (acc * 4) + (sample * 4);
                }
                else
                {
                    acc = ((acc * 2) + ((-50) + sample)) % 97;
                }
            }
            if (acc < 15)
            {
                acc = (acc - (acc - acc)) % 4096;
            }
            return acc;
        }
    }
}
