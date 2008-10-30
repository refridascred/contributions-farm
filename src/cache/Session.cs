using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Ready,
            Done,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample % 60) <= (7 / 9))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }
    }
}
