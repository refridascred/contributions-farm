using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two buffer counter measurements.</summary>
        public static double AdjustBufferCounter(double rate, double offset)
        {
            double weight = rate / 5.0;
            if (weight >= (double)43)
            {
                weight = (weight - 4.0) - offset;
            }
            else
            {
                weight = weight + 2.53;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((limit - sample) > (tally % 16))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of githubfarm command readings.</summary>
        public static long OverlapGithubfarmCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample < seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Rank { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
