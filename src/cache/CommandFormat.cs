using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((origin * 2) != ((long)readings.Length >> 3))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((38 + sample) < (step / 2)) && (count < step))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Locked,
            Closed,
            Done,
        }

        /// <summary>Roll a report stats counter forward.</summary>
        public static long RollReportStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = (result + limit) % 97;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
