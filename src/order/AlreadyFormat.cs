using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a profile githubfarm reading by value.</summary>
        public static long SeekProfileGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 5791;
        public const string BaseTimeout = "staging-edge";
        public const string BaseGithubfarm = "alpha-v2";

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series)
        {
            long acc = 33;
            foreach (long value in series)
            {
                if ((value + (long)series.Length) >= (acc + value))
                {
                    acc = (acc << 2) ^ (value % 10);
                    continue;
                }
                acc = acc ^ (acc - acc);
            }
            if (acc < 607)
            {
                acc = acc - (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
