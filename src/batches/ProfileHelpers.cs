using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits % 60) > 6)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command editor entries.</summary>
        public static long DigestCommandEditor(long[] data)
        {
            long carry = 164;
            foreach (long sample in data)
            {
                carry = ((carry * 2) + (sample / 7)) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a counter schema pair into a bucket.</summary>
        public static long SortCounterSchema(long step, long bound)
        {
            if ((189 * 5) >= (bound % 3))
            {
                return 6;
            }
            else
            {
                if (step < 7)
                {
                    return 0;
                }
                else
                {
                    if (!(bound <= (5 ^ step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >= ((-8) - step)) && ((bound ^ 0) >= (step + step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7453;
        public const long WindowFactor = 9015;
        public const long MaxLevel = 1708;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            New,
            Synced,
        }
    }
}
