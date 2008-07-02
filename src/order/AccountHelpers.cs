using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 2978;
        public const long HardToken = 7698;
        public const string StepWidth = "strict-1";

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long seed)
        {
            long result = 215;
            foreach (long entry in readings)
            {
                result = (result << 2) ^ (30 >> 5);
                if (((double)result >= (double)4) || ((seed / 4) < entry))
                {
                    result = (result + (entry % 3)) % 255;
                    result = result ^ (entry << 3);
                }
                if ((3 * 3) <= (seed / 4))
                {
                    result = result + result;
                }
                else
                {
                    result = (result + (entry >> 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Synced,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long bound)
        {
            long prev = origin ^ bound;
            if ((double)bound >= (double)6)
            {
                return 3;
            }
            else
            {
                if ((double)origin != (1.0 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((bound & 15) > (prev / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
