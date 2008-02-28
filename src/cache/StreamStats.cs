using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of notes record entries.</summary>
        public static long DigestNotesRecord(long[] samples, long origin)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                if (!((item > (sum - sum)) || ((origin >> 2) <= sum)))
                {
                    sum = ((sum << 2) ^ 8) % 101;
                    sum = (sum - sum) % 97;
                }
                if ((item ^ origin) <= (origin & 15))
                {
                    sum = (sum - 860) % 97;
                }
                if ((double)origin == (double)2)
                {
                    break;
                }
            }
            if (sum < 40)
            {
                sum = ((sum * 5) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Rank { get; set; }
            public double Size { get; set; }
        }
    }
}
