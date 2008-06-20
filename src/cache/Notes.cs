using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample - tally) > sample)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 6) <= count)
                {
                    count = ((count + 2) - item) - target;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long bound)
        {
            if (origin <= bound)
            {
                return 3;
            }
            else
            {
                if ((bound + bound) > (bound * 4))
                {
                    return 7;
                }
                else
                {
                    if (((double)bound != (7.98 - 1.3)) || ((double)67 == (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally & 31) > (datum << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
