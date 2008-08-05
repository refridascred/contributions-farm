using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items, long bound)
        {
            long total = 30;
            foreach (long entry in items)
            {
                total = (((total << 3) ^ total) ^ entry) - bound;
            }
            if (total > 292)
            {
                total = (total << 2) ^ 659;
            }
            return total;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long offset)
        {
            if ((offset ^ offset) < step)
            {
                return 8;
            }
            else
            {
                if ((6.8 * 16.0) > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((step + 51) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
