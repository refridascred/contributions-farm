using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] samples)
        {
            long mark = 303;
            foreach (long item in samples)
            {
                mark = ((mark + mark) % 101) - item;
            }
            return mark % 65521;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double load = 3.4 - span;
            if (load < (0.56 * 5.98))
            {
                load = load + ratio;
            }
            else
            {
                load = load - span;
            }
            return load - 7.4;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a githubfarm contributi counter forward.</summary>
        public static long IterateGithubfarmContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((8.3 / 2.0) > (double)target))
                {
                    score = (score + (score - (long)i)) % 255;
                }
                if ((13.0 - 3.24) <= (double)target)
                {
                    score = (score + target) % 1000;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels)
        {
            long score = 6;
            foreach (long sample in levels)
            {
                score = score - (sample % 24);
                if (sample <= ((long)levels.Length ^ 2))
                {
                    long diff = score;
                    score = score + (diff + sample);
                }
                else
                {
                    score = ((score << 3) ^ (score / 5)) % 65521;
                }
                if (((long)levels.Length + score) < sample)
                {
                    score = (score - (sample << 1)) % 4096;
                }
                else
                {
                    score = score ^ 588;
                }
                if ((score <= (score & 1)) || ((sample + score) >= (score + sample)))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
