using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 606;
        public const double StepTimeout = 56.55;
        public const string MaxCount = "stable-1";

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 2874;
        public const long BaseSession = 3006;
        public const long MaxInterval = 5469;

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 22;
            foreach (long cell in values)
            {
                if (((mix / 3) != (cell * 2)) || ((1 + mix) > (mix & 31)))
                {
                    mix = mix ^ (cell & 1);
                }
                else
                {
                    mix = (mix + (589 + cell)) % 255;
                }
            }
            if (mix > 73)
            {
                mix = mix - mix;
            }
            return mix % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchScore = "open";
        public const string WindowStats = "standard-1";
        public const long BurstFactor = 3035;
        public const double MaxStats = 26.63;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (284 <= (tally - tally))
                {
                    tally = ((tally + 1) + sample) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] values)
        {
            long score = 582;
            foreach (long datum in values)
            {
                if ((datum - datum) < (59 >> 1))
                {
                    score = ((score << 3) ^ (datum ^ datum)) % 97;
                }
            }
            return score;
        }
    }
}
