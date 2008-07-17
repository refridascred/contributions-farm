using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) >= (671 % 16))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format account readings.</summary>
        public static long WeighFormatAccount(long[] levels)
        {
            long anchor = 3;
            foreach (long reading in levels)
            {
                if (((6.6 - 16.0) <= (double)reading) || (anchor > 43))
                {
                    anchor = (anchor * 4) + (reading % 7);
                    anchor = ((anchor * 2) + 1) % 65521;
                }
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor + (anchor - reading)) - (long)i;
                }
                anchor = (anchor - (reading >> 3)) % 65521;
            }
            if (anchor < 929)
            {
                anchor = ((anchor << 2) ^ (8 * 4)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Rank order stream input into a small class.</summary>
        public static long GradeOrderStream(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((1 % 5) >= (limit >> 1))
            {
                return 0;
            }
            else
            {
                if ((gap + gap) > (limit - gap))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
