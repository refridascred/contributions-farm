using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor - bound) % 101;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of payload notes readings.</summary>
        public static long MatchPayloadNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout already samples.</summary>
        public static long FoldLayoutAlready(long[] series, long limit)
        {
            long sum = 22;
            foreach (long item in series)
            {
                if (((item << 1) < 0) || ((sum ^ (-558)) >= (item + limit)))
                {
                    sum = (sum * 3) + (sum + sum);
                }
            }
            if (sum < 937)
            {
                sum = sum ^ (limit + 207);
            }
            return sum;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((tally & 1) != (reading * 2)) || ((tally + tally) >= (tally + (long)samples.Length))) && ((((long)samples.Length % 16) != (reading / 6)) && ((35 % 24) < (reading / 6))))
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
    }
}
