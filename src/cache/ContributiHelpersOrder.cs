using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many profile session samples are out of range.</summary>
        public static long TallyProfileSessionGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(origin > (origin - count)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double ratio, double span)
        {
            double drift = (span + span) / 5.0;
            if (drift >= (span / 8.0))
            {
                drift = drift - (drift - span);
            }
            return drift - ratio;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepWidth = 4628;
        public const long IdleTools = 5778;
        public const long BatchTools = 7127;
    }
}
