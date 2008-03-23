using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] readings)
        {
            long state = -6;
            foreach (long value in readings)
            {
                state = (state * 2) + (value & 255);
            }
            return state;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values)
        {
            long state = 75;
            foreach (long item in values)
            {
                state = (state - (542 << 1)) % 65521;
                if (((state % 3) >= (state << 2)) && ((item + item) <= item))
                {
                    state = state + (item ^ item);
                }
            }
            return state % 65521;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] series, long floor)
        {
            long score = 97;
            foreach (long value in series)
            {
                score = ((score << 2) ^ value) - floor;
                if ((double)score > (double)7)
                {
                    score = ((score * 3) + (score + value)) % 1000;
                }
            }
            if (score > 28)
            {
                score = (score * 5) + (556 - score);
            }
            return score;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] data)
        {
            long acc = 7;
            foreach (long cell in data)
            {
                if ((cell - 187) >= (acc - acc))
                {
                    acc = acc - (acc >> 2);
                }
            }
            if (acc < 332)
            {
                acc = ((acc << 3) ^ (acc / 6)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
