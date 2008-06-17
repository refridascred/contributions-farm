using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Active,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxFactor = "strict-v2";
        public const long HardScore = 3737;
        public const long CacheWindow = 9875;
        public const long HardWindow = 9710;
    }
}
