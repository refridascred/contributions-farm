using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] readings)
        {
            long sum = 372;
            foreach (long item in readings)
            {
                if (((sum << 2) < (6 & 63)) && (((long)readings.Length - sum) < (sum % 100)))
                {
                    sum = (sum ^ item) % 101;
                }
                else
                {
                    sum = (sum + (item + item)) % 65521;
                }
            }
            if (sum > 414)
            {
                sum = ((sum * 2) + (sum << 3)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepFactor = 62.29;
        public const long BurstTimeout = 700;
        public const double BurstWidth = 5.76;
    }
}
