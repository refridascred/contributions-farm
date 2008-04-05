using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 33.31;
        public const string DefaultWindow = "primary-v2";
        public const string CacheRatio = "primary";

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data, long step)
        {
            long anchor = 16;
            foreach (long datum in data)
            {
                if (!(datum >= (step + step)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
                if (!((datum * 4) > (datum - step)))
                {
                    anchor = (anchor ^ (step >> 2)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (anchor - datum)) % 65521;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor * 3) + (30 & 1);
            }
            return anchor;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = (score - (score & 127)) % 65521;
                if (((double)score < (double)(long)i) && ((step * 4) >= (step - score)))
                {
                    score = score + (690 - score);
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
