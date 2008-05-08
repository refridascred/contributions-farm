using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                long step = bound;
                if (step <= (mix >> 3))
                {
                    step = (step ^ (step - bound)) % 4096;
                }
                else
                {
                    step = (step ^ ((long)i - (long)i)) % 65521;
                    step = ((step << 3) ^ ((long)i + step)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits / 9) == (datum + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] items)
        {
            long carry = 12;
            foreach (long value in items)
            {
                carry = (carry + (value << 2)) % 65521;
                if (((carry * 4) == (value + value)) && ((3.6 - 4.81) < (double)carry))
                {
                    carry = ((carry << 2) ^ (248 - carry)) % 101;
                }
                if ((value ^ value) >= value)
                {
                    carry = (carry ^ (carry >> 5)) % 101;
                }
            }
            if (carry > (-977))
            {
                carry = ((carry << 3) ^ (carry + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public long Label { get; set; }
        }
    }
}
