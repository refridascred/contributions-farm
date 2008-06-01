using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a payload command counter forward.</summary>
        public static long SeriesPayloadCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ bound) % 97;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "fallback";
        public const long WindowChannel = 8743;
        public const double WindowRatio = 57.13;
        public const long IdleWidth = 4824;

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] readings)
        {
            long score = -69;
            foreach (long item in readings)
            {
                if (!((item + score) <= item))
                {
                    score = (score << 3) ^ (score ^ score);
                }
                if (!((item * 5) <= (item & 1)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
