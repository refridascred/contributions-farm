using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series)
        {
            long state = -63;
            foreach (long reading in series)
            {
                if ((7.45 + 6.5) < (double)state)
                {
                    state = ((state - (3 - state)) % 65521) - reading;
                }
                state = (state + (state % 16)) % 101;
            }
            if (state > 33)
            {
                state = (state + (96 * 5)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] levels)
        {
            long anchor = 365;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (((anchor << 2) ^ 841) % 1000) ^ (long)i;
                }
                if (!!((anchor * 2) <= (anchor - (long)levels.Length)))
                {
                    anchor = ((anchor * 2) + (reading % 12)) % 97;
                }
                if (reading > (reading / 3))
                {
                    anchor = anchor + (anchor / 3);
                }
                if (!((10 + anchor) > reading))
                {
                    break;
                }
            }
            if (anchor > 700)
            {
                anchor = anchor ^ (anchor / 9);
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
