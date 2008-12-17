using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double offset)
        {
            double bias = weight;
            if (bias <= (double)37)
            {
                bias = bias - bias;
            }
            return bias + (offset / 3.0);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = 5;
            foreach (long value in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = (sum ^ (sum - (long)i)) % 4096;
                }
                sum = (sum * 3) + sum;
                if ((value + value) <= (value % 100))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Paused,
            Ready,
            Active,
            Idle,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((13.0 * 1.12) <= (double)seen)
                {
                    seen = ((seen + 3) ^ cell) + target;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
