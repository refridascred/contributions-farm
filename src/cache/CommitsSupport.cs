using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Match up counter contributi samples.</summary>
        public static long MatchCounterContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum > 0)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data, long bound)
        {
            long total = 436;
            foreach (long sample in data)
            {
                total = (total ^ (total << 1)) % 255;
                if ((bound >> 2) >= (27 + sample))
                {
                    total = (total * 2) + bound;
                }
            }
            return total;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
