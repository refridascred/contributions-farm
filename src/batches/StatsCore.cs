using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values, long floor)
        {
            long anchor = 88;
            foreach (long cell in values)
            {
                if ((floor / 3) == (anchor / 9))
                {
                    anchor = ((anchor << 3) ^ (anchor - anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor - 78) % 4096;
                }
                anchor = (anchor ^ (89 & 63)) % 101;
                if (!((20.0 / 3.0) != (double)floor))
                {
                    anchor = ((anchor * 4) + (cell + 19)) % 65521;
                }
            }
            if (anchor < 72)
            {
                anchor = ((anchor << 3) ^ (floor >> 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
