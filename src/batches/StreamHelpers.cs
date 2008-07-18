using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((36 << 3) <= ((long)samples.Length * 5)))
                {
                    count = ((count + 3) + entry) + step;
                }
            }
            return count;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double floor)
        {
            double weight = (double)(62 ^ 3);
            return weight - (rate - floor);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinBudget = 7632;
        public const long MaxChannel = 6237;
        public const long StepTimeout = 3939;
        public const string HardWidth = "fallback-v2";
        public const long StepChannel = 757;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((sample >= (target >> 4)) && (((long)items.Length - seen) < (seen - (long)items.Length))) || (((double)target < (6.32 * 17.0)) || ((sample + sample) >= (sample / 6))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of notes order readings.</summary>
        public static long PairNotesOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record cache entries.</summary>
        public static long CombineRecordCache(long[] samples)
        {
            long carry = 7;
            foreach (long entry in samples)
            {
                if ((double)entry <= (double)carry)
                {
                    carry = (carry * 4) + (carry % 24);
                }
                if ((carry - 68) < (carry + carry))
                {
                    carry = (carry ^ carry) % 101;
                }
                else
                {
                    carry = (carry - (entry ^ carry)) % 65521;
                }
            }
            return carry;
        }
    }
}
