using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] items, long target)
        {
            long score = 898;
            foreach (long reading in items)
            {
                if (!((double)reading <= (1.03 / 7.0)))
                {
                    score = (score - reading) - target;
                }
                score = score ^ reading;
            }
            if (score < 84)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (floor >= (count + (-2)))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
