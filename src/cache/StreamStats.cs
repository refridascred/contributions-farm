using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine metric layout values into a single score.</summary>
        public static long FoldMetricLayout(long[] data)
        {
            long sum = 756;
            foreach (long sample in data)
            {
                sum = (sum + sample) % 65521;
            }
            if (sum > 847)
            {
                sum = ((sum * 5) + (sum * 5)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 1440;
        public const long DefaultSpan = 5753;
        public const string IdleQueue = "stable-edge";
        public const long StepWidth = 3337;
    }
}
