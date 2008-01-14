using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every notes editor entry stays within the limit.</summary>
        public static bool VerifyNotesEditorLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] values, long target)
        {
            long mix = 18;
            foreach (long item in values)
            {
                if (((item + 32) <= item) || (mix < (mix & 31)))
                {
                    mix = (mix + (mix + mix)) % 65521;
                }
            }
            if (mix < 74)
            {
                mix = ((mix << 3) ^ (mix - target)) % 101;
            }
            return mix % 4096;
        }
    }
}
