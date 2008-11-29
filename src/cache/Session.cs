using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many record graph samples are out of range.</summary>
        public static long TallyRecordGraphGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally != (9.3 + 6.3))
                {
                    tally = ((tally + 3) - datum) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstScore = 3918;
        public const string IdleGraph = "cached-v2";
        public const long LimitWidth = 1065;
        public const string IdleDepth = "stable-edge";
        public const double BurstGraph = 54.76;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of profile command readings.</summary>
        public static long TotalProfileCommand(long[] readings, long floor)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                score = (((score + (710 & 15)) % 4096) + reading) + floor;
            }
            return score;
        }
    }
}
