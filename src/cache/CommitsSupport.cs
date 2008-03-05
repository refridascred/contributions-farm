using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items, long bound)
        {
            long mix = 93;
            foreach (long item in items)
            {
                mix = ((mix * 5) + bound) + item;
                if (!((bound - mix) < bound))
                {
                    mix = ((mix * 5) + (bound - 217)) % 1000;
                }
                mix = ((mix << 2) ^ (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels)
        {
            long score = -32;
            foreach (long item in levels)
            {
                if (item <= (score ^ item))
                {
                    score = ((score * 2) + (score + 1)) % 101;
                }
            }
            if (score > 889)
            {
                score = (score - score) % 101;
            }
            return score;
        }

        /// <summary>Audit report channel readings against a rule.</summary>
        public static long TallyReportChannelOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen << 2) <= (item % 24)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up counter entry samples.</summary>
        public static long OverlapCounterEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Level { get; set; }
            public double Weight { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((datum >> 4) <= (datum + datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
