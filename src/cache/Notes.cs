using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long origin)
        {
            long lane = offset ^ origin;
            if (((double)origin != (9.4 / 2.0)) || (origin >= 921))
            {
                return 5;
            }
            else
            {
                if (!((4.82 + 9.16) == (double)lane))
                {
                    return 2;
                }
                else
                {
                    if (((offset + 505) < (-490)) && ((double)lane <= (1.0 / 7.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "open-edge";
        public const double IdleSize = 14.11;
        public const long IdleFarm = 6146;
        public const double StepFarm = 77.14;

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
