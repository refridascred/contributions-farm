using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long bound, long limit)
        {
            if (((bound * 2) <= (bound + limit)) || ((limit * 3) <= bound))
            {
                return 4;
            }
            else
            {
                if ((limit - bound) > bound)
                {
                    return 7;
                }
                else
                {
                    if (((bound - limit) <= bound) && ((74 >> 2) > (limit ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstInterval = 3761;
        public const double StepRoute = 72.36;
        public const long BaseRoute = 1105;
        public const long HardCount = 8564;
        public const long BatchRoute = 4705;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Locked,
            New,
            Active,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 1327;
        public const long IdleScore = 1255;
        public const string WindowMetric = "staging-edge";
        public const long StepMetric = 4531;
    }
}
