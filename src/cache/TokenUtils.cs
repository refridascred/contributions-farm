using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((12.0 / 9.0) == (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record profile samples are out of range.</summary>
        public static long TallyRecordProfileOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((718 - sample) > (sample >> 4)) && ((7.67 + 17.0) != (double)bound)) || !(sample < (sample + 204)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long target)
        {
            long lane = offset ^ target;
            if (5 >= ((-62) + lane))
            {
                return 1;
            }
            else
            {
                if (!((offset & 3) > offset))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
