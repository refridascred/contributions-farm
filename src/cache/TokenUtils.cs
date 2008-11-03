using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a command contributi counter forward.</summary>
        public static long IterateCommandContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((877 + datum) != (datum - 5))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm record counter forward.</summary>
        public static long StepGithubfarmRecord(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                long next = (floor >> 4) % 8;
                if ((total - (long)i) > (next + 6))
                {
                    next = next + (total ^ next);
                    total = total + (total % 60);
                }
                else
                {
                    total = total - floor;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
