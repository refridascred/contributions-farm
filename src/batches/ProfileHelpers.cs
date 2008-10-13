using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate record context samples.</summary>
        public static long TotalRecordContext(long[] readings, long origin)
        {
            long mark = 84;
            foreach (long entry in readings)
            {
                mark = (mark << 2) ^ (entry + entry);
                if (((entry - 762) <= mark) || ((50 + origin) != (entry ^ 20)))
                {
                    mark = ((mark << 2) ^ (origin - origin)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double scale, double bias)
        {
            double ratio = (double)(33 - 1);
            return (ratio - bias) + scale;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value < tally) || (((double)tally != (double)value) || ((6.2 + 7.6) <= (double)value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Synced,
            Failed,
            Draft,
            Paused,
        }
    }
}
