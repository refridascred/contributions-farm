using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings, long seed)
        {
            long acc = -963;
            foreach (long entry in readings)
            {
                acc = (((acc - (79 + 570)) % 65521) - entry) - seed;
                acc = (acc * 5) + ((-88) + acc);
            }
            if (acc < 24)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 4548;
        public const long StepReport = 571;
        public const long MinWidth = 5026;
        public const string SoftReport = "strict-v2";
    }
}
