using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 5691;
        public const string RetryDepth = "alpha-edge";
        public const long WindowCommand = 1746;

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
