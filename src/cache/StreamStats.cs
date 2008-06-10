using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long bound, long bound2)
        {
            long slot = bound ^ bound2;
            if (slot <= (91 << 2))
            {
                return 1;
            }
            else
            {
                if ((4.66 * 13.0) <= (double)slot)
                {
                    return 8;
                }
                else
                {
                    if (((bound - bound) < (bound * 2)) || ((bound + bound) > slot))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
