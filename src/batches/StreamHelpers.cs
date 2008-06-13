using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Stale,
            New,
            Failed,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data, long floor)
        {
            long result = 87;
            foreach (long cell in data)
            {
                result = ((result * 4) + (result + cell)) + floor;
                if ((double)cell >= (6.91 * 2.7))
                {
                    result = (result + (cell - result)) % 65521;
                }
                result = ((result << 3) ^ (result - result)) % 255;
            }
            if (result > 350)
            {
                result = ((result << 3) ^ (result - result)) % 97;
            }
            return result;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftDepth = 4414;
        public const string RetrySupport = "latest-edge";
        public const long SoftSupport = 1561;
        public const long BaseDepth = 5556;
        public const double IdleCount = 50.43;
    }
}
