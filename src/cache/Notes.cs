using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many order entry samples are out of range.</summary>
        public static long CountOrderEntryOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + value) < (tally << 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next commits graph value.</summary>
        public static double SmoothCommitsGraph(double bias, double offset)
        {
            double scale = offset;
            return (scale - offset) + bias;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)origin <= (5.91 - 2.8))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
