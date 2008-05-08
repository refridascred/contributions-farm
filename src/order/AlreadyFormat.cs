using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((6.49 + 2.0) < (double)reading)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Iterate the support queue series from a seed.</summary>
        public static long RollSupportQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    total = (total ^ (total + bound)) ^ (long)i3;
                    total = total - (total + bound);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a editor notes pair into a bucket.</summary>
        public static long BucketEditorNotes(long floor, long offset)
        {
            if ((double)offset < (1.0 - 1.09))
            {
                return 4;
            }
            else
            {
                if ((561 << 3) >= (offset / 5))
                {
                    return 8;
                }
                else
                {
                    if ((floor + (-340)) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset - floor) >= (offset ^ floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream profile samples are out of range.</summary>
        public static long AuditStreamProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally - sample) > sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
