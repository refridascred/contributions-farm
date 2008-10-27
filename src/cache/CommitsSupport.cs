using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 7591;
        public const string CacheWidth = "alpha-edge";
        public const string WindowGithubfarm = "standard-v2";
        public const double StepSpan = 7.69;

        /// <summary>Validate githubfarm token readings against a bound.</summary>
        public static bool GuardGithubfarmTokenLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Paused,
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
