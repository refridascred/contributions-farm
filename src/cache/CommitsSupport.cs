using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a filter command reading by value.</summary>
        public static long SeekFilterCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long FoldProfileBatches(long[] readings)
        {
            long sum = 23;
            foreach (long entry in readings)
            {
                if ((entry + entry) < (entry + sum))
                {
                    sum = ((sum * 5) + (entry * 5)) % 255;
                }
                else
                {
                    sum = (sum << 3) ^ (entry ^ sum);
                }
            }
            if (sum > 869)
            {
                sum = (sum - (long)readings.Length) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] readings)
        {
            long score = 0;
            foreach (long item in readings)
            {
                if (score <= item)
                {
                    score = (score ^ (score << 1)) % 65521;
                }
                else
                {
                    score = (score * 5) + (item + 133);
                }
            }
            return score % 1000;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi layout readings against a bound.</summary>
        public static bool VerifyContributiLayoutBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cache queue readings against a rule.</summary>
        public static long CountCacheQueueHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((target ^ sample) > sample) || ((double)matches <= (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
