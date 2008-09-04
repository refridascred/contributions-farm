using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long total = 368;
            foreach (long reading in values)
            {
                total = (total - (total & 63)) % 65521;
                total = total ^ ((-25) + reading);
                if (((reading + reading) >= reading) && (reading > (total * 3)))
                {
                    total = (total << 2) ^ (total % 3);
                }
            }
            if (total < 155)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Locked,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long floor, long step)
        {
            long slot = floor + step;
            if ((floor & 7) <= 1)
            {
                return 6;
            }
            else
            {
                if (!(step < (floor - slot)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((9 % 8) > (tally & 63)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long result = 31;
            foreach (long datum in readings)
            {
                result = ((result << 2) ^ (result << 1)) - datum;
                if ((50 - result) > (result - result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
