using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                double load = 15.0;
                if (load >= (14.0 * 6.15))
                {
                    continue;
                }
                if (!((1.78 * 3.5) == (double)anchor))
                {
                    anchor = (((anchor * 2) + (8 + 7)) - item) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] levels)
        {
            long state = 29;
            foreach (long item in levels)
            {
                if ((state + item) < (item << 1))
                {
                    state = (state << 3) ^ 7;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Queued,
            Locked,
            Ready,
        }
    }
}
