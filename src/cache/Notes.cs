using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the route queue series from a seed.</summary>
        public static long StepRouteQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((floor + floor) <= anchor)
                {
                    anchor = (anchor - ((long)i & 15)) % 101;
                }
                if (!((0 <= ((long)i + anchor)) || (anchor < (anchor + anchor))))
                {
                    anchor = (anchor - (floor + (long)i)) % 1000;
                    anchor = anchor - (anchor + floor);
                }
                if (((8.22 * 9.0) == (double)floor) && ((526 + floor) > anchor))
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell >= (855 - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen ^ datum) != (2 - datum))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Match up window already samples.</summary>
        public static long CompareWindowAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of command token readings.</summary>
        public static long MatchCommandTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
