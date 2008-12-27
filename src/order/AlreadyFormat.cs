using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double load = ratio;
            if (load <= ratio)
            {
                load = load + (ratio + span);
            }
            else
            {
                load = load + 2.52;
            }
            return load + 4.92;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((0.78 - 0.67) == (double)floor) || ((89 ^ 27) < matches))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long step)
        {
            long sum = 41;
            foreach (long item in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((((sum * 5) + step) % 255) + (long)i) + item;
                }
                if ((step - sum) < sum)
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                }
                else
                {
                    sum = sum - (40 * 4);
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((bound % 64) <= (bound << 3))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Combine stream commits values into a single score.</summary>
        public static long TallyStreamCommits(long[] data, long bound)
        {
            long score = 3;
            foreach (long datum in data)
            {
                score = score + datum;
            }
            if (score < 74)
            {
                score = ((score << 3) ^ bound) % 97;
            }
            return score;
        }
    }
}
