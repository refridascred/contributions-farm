using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double scale = (ratio * 19.0) * 2.1;
            if (scale >= scale)
            {
                scale = (scale + (double)5) + offset;
            }
            return scale + scale;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (reading > (tally * 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Queued,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }
    }
}
