using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first buffer context entry that matches the target.</summary>
        public static long LookupBufferContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics route samples.</summary>
        public static long TotalMetricsRoute(long[] samples, long offset)
        {
            long total = 989;
            foreach (long cell in samples)
            {
                total = (((total * 4) + ((-985) << 2)) % 255) - cell;
                for (int i = 0; i < 5; i++)
                {
                    total = (((total * 4) + (36 / 2)) % 65521) - (long)i;
                }
                total = ((total * 4) + offset) % 97;
                if (!((9.5 + 4.13) <= (double)offset))
                {
                    break;
                }
            }
            if (total > 51)
            {
                total = (total * 3) + offset;
            }
            return total % 97;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Find the first account profile entry that matches the target.</summary>
        public static long FindAccountProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double gain, double floor)
        {
            double weight = gain * 9.59;
            if (weight < gain)
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + floor) - (double)(long)i;
            }
            return weight + gain;
        }
    }
}
