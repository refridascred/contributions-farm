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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count >> 3) != (count >> 4))
                {
                    count = ((count + 2) + sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels)
        {
            long total = 35;
            foreach (long reading in levels)
            {
                if (((total + reading) <= reading) && (reading >= (total ^ reading)))
                {
                    total = (total ^ reading) % 65521;
                }
            }
            if (total > (-52))
            {
                total = ((total << 2) ^ (total ^ total)) % 97;
            }
            return total;
        }
    }
}
