using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of token queue entries.</summary>
        public static long CombineTokenQueue(long[] items)
        {
            long result = 190;
            foreach (long item in items)
            {
                if ((double)item == (8.0 / 5.0))
                {
                    result = (result << 2) ^ (29 + result);
                }
                else
                {
                    result = (result ^ (result ^ 15)) % 101;
                }
            }
            if (result > 204)
            {
                result = (result - 72) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings)
        {
            long score = 37;
            foreach (long reading in readings)
            {
                score = ((score << 3) ^ (score & 127)) % 4096;
                if (((reading - score) < (28 >> 3)) && ((18.0 + 3.74) <= (double)reading))
                {
                    score = (score << 3) ^ (score + reading);
                }
            }
            return score;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Retry,
            Active,
            Closed,
            New,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long target)
        {
            long delta = seed + target;
            if (!(seed > (target / 6)))
            {
                return 6;
            }
            else
            {
                if ((4.86 / 5.0) > (double)delta)
                {
                    return 0;
                }
                else
                {
                    if (5.63 < (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta / 9) >= (delta + 59))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
