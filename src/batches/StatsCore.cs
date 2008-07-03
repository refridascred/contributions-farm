using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double gain, double floor)
        {
            double mean = gain / 3.0;
            if (mean <= (3.8 - 9.21))
            {
                mean = (mean - (double)(-102)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (mean / 2.0);
        }

        /// <summary>Count stream schema pairs that satisfy a relation.</summary>
        public static long CompareStreamSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry << 2) >= (hits * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of layout githubfarm entries.</summary>
        public static long WeighLayoutGithubfarm(long[] series, long floor)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                anchor = (anchor << 3) ^ (0 / 2);
                if (reading > (floor % 7))
                {
                    anchor = (anchor - (anchor + anchor)) % 4096;
                    break;
                }
                else
                {
                    anchor = (anchor ^ (floor + (long)series.Length)) % 4096;
                }
                anchor = (anchor + (9 * 3)) % 65521;
            }
            if (anchor > 6)
            {
                anchor = (anchor * 3) + (anchor ^ anchor);
            }
            return anchor % 65521;
        }
    }
}
