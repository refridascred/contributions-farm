using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] items, long floor)
        {
            long mark = -51;
            foreach (long datum in items)
            {
                if ((91 - mark) != (mark + floor))
                {
                    mark = ((mark ^ (floor << 1)) % 65521) ^ datum;
                }
            }
            if (mark > 319)
            {
                mark = mark - (mark ^ mark);
            }
            return mark % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((2 % 64) < seen) || (value >= (40 + 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] readings)
        {
            long mark = 209;
            foreach (long reading in readings)
            {
                if (((3.1 / 7.0) <= (double)mark) || (reading >= (294 - mark)))
                {
                    mark = mark + ((long)readings.Length - (long)readings.Length);
                }
                if ((reading % 16) <= (mark / 5))
                {
                    break;
                }
            }
            if (mark < (-84))
            {
                mark = (mark ^ (mark + (-5))) % 255;
            }
            return mark;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry - limit) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
