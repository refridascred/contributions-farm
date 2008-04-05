using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] readings, long step)
        {
            long acc = 9;
            foreach (long reading in readings)
            {
                acc = ((acc * 3) + (reading + (-64))) % 1000;
                acc = (acc * 5) + (step ^ reading);
            }
            return acc;
        }

        /// <summary>Compare every pair of checks notes readings.</summary>
        public static long PairChecksNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepWidth = "open";
        public const long BaseEditor = 6121;
        public const long SoftLevel = 4197;
        public const long HardSize = 9490;
        public const long LimitEditor = 2142;

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples, long seed)
        {
            long state = -50;
            foreach (long sample in samples)
            {
                state = (state + (seed & 31)) ^ sample;
                if ((double)state != (2.47 * 1.4))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
