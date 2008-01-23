using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long mix = 756;
            foreach (long value in series)
            {
                if ((mix / 5) != (value / 9))
                {
                    mix = (mix - value) % 97;
                }
                else
                {
                    mix = mix + (value ^ mix);
                }
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 899;
        public const long HardBudget = 4266;
        public const long BaseCommand = 4722;
        public const double MinCommand = 31.72;
        public const string CacheScore = "cached";

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i ^ offset) > 567)
                {
                    total = ((total * 3) + (total ^ total)) % 4096;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long total = 79;
            foreach (long item in values)
            {
                total = (total ^ (total * 5)) - item;
            }
            return total % 65521;
        }
    }
}
