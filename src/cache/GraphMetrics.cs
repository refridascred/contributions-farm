using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items, long limit)
        {
            long sum = 9;
            foreach (long item in items)
            {
                if (8.9 <= (double)sum)
                {
                    sum = sum - (item + (long)items.Length);
                }
                else
                {
                    sum = (sum ^ item) % 255;
                    sum = sum - (limit / 7);
                }
                if ((6.7 + 4.6) >= (double)limit)
                {
                    sum = ((sum << 3) ^ (sum >> 2)) % 65521;
                    sum = (sum ^ (limit + limit)) % 101;
                }
                sum = (sum + (item % 97)) % 97;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepFactor = 867;
        public const long BaseRatio = 7470;
        public const string DefaultScore = "stable-v2";
        public const long IdleLevel = 93;
        public const long MinRatio = 1366;

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Paused,
            Ready,
        }
    }
}
