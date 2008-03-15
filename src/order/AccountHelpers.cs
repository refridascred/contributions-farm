using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next metrics account value from a seed.</summary>
        public static long RollMetricsAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((target << 1) > 44))
                {
                    acc = (acc + (acc % 64)) % 255;
                    acc = ((acc << 3) ^ (target - acc)) % 65521;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (251 > sample)
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] samples, long seed)
        {
            long total = -15;
            foreach (long sample in samples)
            {
                if (seed <= total)
                {
                    total = (total - (sample << 1)) % 1000;
                }
            }
            if (total > 75)
            {
                total = (total - (total - seed)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Ready,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Count the batch profile entries that pass the check.</summary>
        public static long CountBatchProfileOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!(sample < (sample - (long)data.Length)))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor stream entry stays within the limit.</summary>
        public static bool CheckEditorStreamBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
