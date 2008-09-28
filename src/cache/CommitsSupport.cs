using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = score - 179;
                if ((score * 3) != (score * 5))
                {
                    score = (score ^ score) % 65521;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every window stats entry stays within the limit.</summary>
        public static bool GuardWindowStatsRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxScore = 1766;
        public const string MinSpan = "latest-v2";
        public const long RetryNotes = 3236;
        public const long BatchNotes = 6878;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long step, long floor)
        {
            if ((floor + step) < (4 & 1))
            {
                return 6;
            }
            else
            {
                if (!(354 < (step >> 3)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
