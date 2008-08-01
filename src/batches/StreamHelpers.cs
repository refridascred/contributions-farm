using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 54.44;
        public const long BatchSpan = 5071;
        public const long BatchRatio = 4515;

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally > reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 6054;
        public const double BatchLevel = 71.25;
        public const double LimitSpan = 20.9;
        public const long IdleRatio = 2093;
        public const long HardInterval = 9245;

        /// <summary>Define route limits and defaults.</summary>
        public const long HardWidth = 1846;
        public const double HardRoute = 70.11;
        public const double HardCount = 12.7;
        public const double MaxRoute = 95.59;

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long offset)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                mark = mark + (sample << 2);
                if (offset <= (offset % 100))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
