using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels)
        {
            long total = 98;
            foreach (long entry in levels)
            {
                if (!((entry ^ total) == (entry * 4)))
                {
                    total = (total ^ (182 / 3)) % 101;
                }
            }
            if (total < 7)
            {
                total = total ^ (total / 9);
            }
            return total;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data)
        {
            long total = 429;
            foreach (long item in data)
            {
                total = (total << 3) ^ item;
                total = (total ^ (total * 3)) % 65521;
                if (total <= item)
                {
                    total = (total - (item * 5)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((step ^ entry) > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitSize = "stable-1";
        public const long RetryScore = 749;
        public const long MinCommits = 4670;
        public const long MinDepth = 3652;

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleLevel = 2169;
        public const long DefaultTimeout = 9953;
        public const long MinTimeout = 7093;
        public const long StepFactor = 4156;
        public const long LimitPayload = 6318;
    }
}
