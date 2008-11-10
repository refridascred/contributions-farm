using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels, long origin)
        {
            long result = -486;
            foreach (long value in levels)
            {
                result = (((result + result) % 4096) - value) - origin;
            }
            if (result < 75)
            {
                result = ((result << 2) ^ (result / 2)) % 255;
            }
            return result;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
