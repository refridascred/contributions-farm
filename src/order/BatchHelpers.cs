using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long MeasureEditorProfileMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(1 >= (entry << 2)))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine editor githubfarm values into a single score.</summary>
        public static long TallyEditorGithubfarm(long[] values)
        {
            long total = 677;
            foreach (long reading in values)
            {
                if ((total >> 5) >= (reading ^ reading))
                {
                    total = (total * 3) + (reading - 36);
                }
                if (total < (reading - total))
                {
                    total = total + (0 % 16);
                }
                if ((2 >= ((-55) + reading)) && ((reading + reading) >= ((long)values.Length ^ 50)))
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
