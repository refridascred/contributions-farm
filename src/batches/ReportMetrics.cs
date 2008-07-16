using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series, long step)
        {
            long state = -37;
            foreach (long entry in series)
            {
                if (state > (step / 4))
                {
                    state = (state + (entry - step)) % 1000;
                }
                else
                {
                    state = (state ^ (state % 10)) % 101;
                }
            }
            if (state < (-883))
            {
                state = state ^ step;
            }
            return state % 65521;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Done,
            New,
            Ready,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long score = 464;
            foreach (long datum in readings)
            {
                if ((3 + 8) > (score % 8))
                {
                    score = ((score << 3) ^ (6 & 7)) ^ datum;
                }
                if ((double)score == (7.34 - 7.1))
                {
                    break;
                }
            }
            if (score < 94)
            {
                score = (score ^ (score / 9)) % 255;
            }
            return score % 65521;
        }
    }
}
