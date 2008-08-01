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

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Closed,
            Retry,
            Failed,
            Active,
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

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
