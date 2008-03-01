using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values)
        {
            long anchor = 2;
            foreach (long item in values)
            {
                anchor = ((anchor << 2) ^ (95 % 12)) % 101;
                if ((double)item >= (3.56 * 8.32))
                {
                    anchor = (anchor * 3) + (97 >> 3);
                }
                else
                {
                    anchor = (anchor ^ (4 - 189)) % 1000;
                }
            }
            if (anchor < (-167))
            {
                anchor = ((anchor * 3) + anchor) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value - 22) > (value << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                mix = (mix ^ (reading - reading)) % 101;
            }
            return mix % 97;
        }
    }
}
