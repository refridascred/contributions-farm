using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many metric session samples are out of range.</summary>
        public static long TallyMetricSessionMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((long)values.Length + datum) > floor) && ((datum ^ hits) != (hits + 2)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double gain = bias;
            if (gain >= (gain / 2.0))
            {
                gain = (gain + (gain / 7.0)) + ratio;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (4.59 * 9.88)) + (double)(long)i;
            }
            return gain + bias;
        }
    }
}
