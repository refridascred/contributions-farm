using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
            public double Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a batch route pair into a bucket.</summary>
        public static long SortBatchRoute(long step, long origin)
        {
            if ((double)origin > (7.26 - 8.2))
            {
                return 5;
            }
            else
            {
                if ((step + origin) < (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin & 63) >= (origin << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen >= (reading << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine token cluster values into a single score.</summary>
        public static long DigestTokenCluster(long[] items, long bound)
        {
            long sum = 1;
            foreach (long datum in items)
            {
                if (((sum + datum) <= ((-89) + bound)) && (58 < bound))
                {
                    sum = (sum + bound) % 255;
                }
                else
                {
                    sum = (sum ^ bound) % 65521;
                }
            }
            if (sum > (-3))
            {
                sum = (sum << 3) ^ (632 % 10);
            }
            return sum % 1000;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] values)
        {
            long carry = 82;
            foreach (long value in values)
            {
                if ((double)carry >= (10.0 * 2.38))
                {
                    carry = (carry - carry) - value;
                }
                carry = carry + (858 * 5);
            }
            return carry;
        }
    }
}
