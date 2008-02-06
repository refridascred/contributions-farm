using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels)
        {
            long sum = 155;
            foreach (long sample in levels)
            {
                if ((sample * 3) <= 1)
                {
                    sum = sum - sum;
                }
            }
            return sum;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command format entries.</summary>
        public static long CombineCommandFormat(long[] items)
        {
            long state = 72;
            foreach (long item in items)
            {
                state = (state ^ item) % 101;
                state = ((state << 2) ^ state) % 101;
            }
            if (state < 4)
            {
                state = ((state << 2) ^ (state ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long origin)
        {
            long score = 25;
            foreach (long item in samples)
            {
                if (!((double)item == (2.0 - 6.6)))
                {
                    score = ((score << 2) ^ origin) % 65521;
                }
            }
            if (score > 1)
            {
                score = (score << 3) ^ (origin / 3);
            }
            return score;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
