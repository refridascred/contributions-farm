using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Queued,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "strict-1";
        public const long LimitInterval = 9408;
        public const long HardEntry = 75;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (matches >= cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Ready,
            Draft,
            Done,
        }
    }
}
