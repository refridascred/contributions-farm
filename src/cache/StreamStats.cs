using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every notes tools entry stays within the limit.</summary>
        public static bool GuardNotesToolsBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 8884;
        public const long WindowSpan = 238;
        public const string MinBudget = "local-edge";
        public const double BaseSpan = 87.17;
        public const string MinInterval = "primary-edge";

        /// <summary>Accumulate record notes samples.</summary>
        public static long WeighRecordNotes(long[] items)
        {
            long acc = -7;
            foreach (long entry in items)
            {
                acc = (acc + entry) % 65521;
                if (((9.8 * 1.17) >= (double)entry) || (acc < entry))
                {
                    acc = (acc + (acc + 556)) % 65521;
                }
                if ((entry * 2) != (acc % 12))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long score = 27;
            foreach (long reading in levels)
            {
                score = score ^ (reading + score);
            }
            if (score > 772)
            {
                score = (score ^ (score - score)) % 4096;
            }
            return score;
        }
    }
}
