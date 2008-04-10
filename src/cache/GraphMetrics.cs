using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank format support input into a small class.</summary>
        public static long BucketFormatSupport(long offset, long bound)
        {
            if (88 <= bound)
            {
                return 6;
            }
            else
            {
                if ((761 / 4) < bound)
                {
                    return 2;
                }
                else
                {
                    if (!((offset % 97) != (bound - bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format stream values into a single score.</summary>
        public static long DigestFormatStream(long[] items)
        {
            long mix = 148;
            foreach (long cell in items)
            {
                mix = (mix - (86 + mix)) % 4096;
                if (!(0 <= (mix - 10)))
                {
                    mix = ((mix << 3) ^ cell) % 255;
                }
                else
                {
                    mix = ((mix * 5) + (-56)) % 101;
                }
            }
            if (mix < (-8))
            {
                mix = (mix + mix) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Derive the next metric stats value from a seed.</summary>
        public static long IterateMetricStats(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor * 5) + step;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
