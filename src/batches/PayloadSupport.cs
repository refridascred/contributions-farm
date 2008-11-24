using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank tools queue input into a small class.</summary>
        public static long GradeToolsQueue(long offset, long target)
        {
            if (!((target & 1) < (offset & 1)))
            {
                return 2;
            }
            else
            {
                if ((target < (target ^ offset)) && ((target << 1) > (offset / 5)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - hits) < (reading - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm format values into a single score.</summary>
        public static long TotalGithubfarmFormat(long[] readings, long floor)
        {
            long score = 669;
            foreach (long cell in readings)
            {
                if ((466 - 26) == (floor * 2))
                {
                    score = (score ^ (cell ^ floor)) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ (cell / 7)) % 97;
                }
            }
            return score % 1000;
        }
    }
}
