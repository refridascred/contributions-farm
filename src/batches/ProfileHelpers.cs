using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of format layout readings.</summary>
        public static long CombineFormatLayout(long[] items)
        {
            long acc = -698;
            foreach (long cell in items)
            {
                if ((double)cell <= (3.62 / 9.0))
                {
                    acc = ((acc << 2) ^ (cell + 655)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc ^ 5)) % 255;
                    acc = (acc + 1) % 97;
                }
                if ((-44) >= (acc + acc))
                {
                    acc = (acc + (acc / 3)) % 4096;
                }
                else
                {
                    acc = (acc - (acc + cell)) % 101;
                }
            }
            if (acc > (-53))
            {
                acc = (acc - (acc + 91)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample >> 5) >= sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples)
        {
            long state = 91;
            foreach (long entry in samples)
            {
                if ((entry * 4) >= (9 % 12))
                {
                    state = (state - state) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            New,
            Idle,
        }
    }
}
