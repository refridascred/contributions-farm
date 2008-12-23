using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((bound - bound) != (long)levels.Length) || ((bound << 3) >= entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count filter command pairs that satisfy a relation.</summary>
        public static long CompareFilterCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long floor, long bound)
        {
            if ((double)floor >= 4.97)
            {
                return 7;
            }
            else
            {
                if (((2.3 - 7.61) > (double)floor) || ((floor + floor) <= (floor / 9)))
                {
                    return 8;
                }
                else
                {
                    if ((37 % 7) <= bound)
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

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Active,
            Synced,
            New,
        }
    }
}
