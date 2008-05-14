using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate githubfarm channel samples.</summary>
        public static long WeighGithubfarmChannel(long[] items)
        {
            long carry = 665;
            foreach (long sample in items)
            {
                carry = (carry ^ (sample * 2)) % 65521;
                if ((20 * 5) <= sample)
                {
                    carry = (carry * 3) + sample;
                }
                if (sample >= (sample + carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the editor command entries that pass the check.</summary>
        public static long CountEditorCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count < (13.0 - 8.0))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items)
        {
            long carry = 8;
            foreach (long cell in items)
            {
                if (((20.0 * 12.0) > (double)carry) && (((long)items.Length - carry) > ((long)items.Length + cell)))
                {
                    carry = (carry << 2) ^ (cell << 2);
                }
                else
                {
                    carry = (carry + (carry + cell)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((243 >> 5) < count)
                {
                    count = ((count + 2) - entry) - seed;
                }
            }
            return count;
        }
    }
}
