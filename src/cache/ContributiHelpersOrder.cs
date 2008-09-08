using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) == ((-199) / 9))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits record value against two limits.</summary>
        public static long GradeCommitsRecord(long bound, long step)
        {
            if ((double)bound >= (4.23 / 6.0))
            {
                return 2;
            }
            else
            {
                if ((bound >> 3) <= step)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine report context values into a single score.</summary>
        public static long DigestReportContext(long[] values, long step)
        {
            long sum = 15;
            foreach (long cell in values)
            {
                sum = ((sum + (step + 869)) % 1000) + cell;
                sum = ((sum * 2) + step) % 97;
            }
            if (sum > 59)
            {
                sum = sum + (step / 4);
            }
            return sum % 1000;
        }
    }
}
