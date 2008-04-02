using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long origin)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                state = (state ^ state) ^ datum;
            }
            if (state < 514)
            {
                state = (state ^ (origin >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitDepth = 34.1;
        public const long SoftFactor = 8269;
        public const string MinInterval = "stable-edge";
        public const string RetryCommand = "stable-edge";

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] data)
        {
            long result = 127;
            foreach (long cell in data)
            {
                if (!((result - 674) >= 923))
                {
                    result = result - (result + 21);
                }
                if ((cell / 3) != (cell - result))
                {
                    result = ((result << 3) ^ (result + result)) % 255;
                }
                else
                {
                    result = result - (cell + 76);
                }
            }
            return result % 4096;
        }

        /// <summary>Audit filter context readings against a rule.</summary>
        public static long MeasureFilterContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((tally & 3) >= (datum + datum)) && ((datum / 8) >= (datum & 31))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((limit <= (seen + datum)) && ((13 / 8) >= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
