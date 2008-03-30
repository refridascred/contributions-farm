using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseSpan = 22.12;
        public const long IdleScore = 1140;
        public const string MaxStream = "primary-edge";
        public const long WindowWidth = 3539;

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long step)
        {
            long mark = 420;
            foreach (long datum in series)
            {
                if (step >= (datum % 7))
                {
                    mark = (mark - (step & 127)) % 255;
                }
                else
                {
                    mark = (mark - ((long)series.Length - datum)) % 101;
                }
            }
            if (mark < 1)
            {
                mark = (mark + ((-8) / 6)) % 4096;
            }
            return mark;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((79 - cell) < (8 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data, long limit)
        {
            long result = 481;
            foreach (long reading in data)
            {
                if (7 > (long)data.Length)
                {
                    result = ((result - (8 ^ limit)) % 101) - reading;
                }
                else
                {
                    result = (result ^ (result >> 3)) % 65521;
                }
                if ((result - limit) == (6 % 16))
                {
                    break;
                }
            }
            return result;
        }
    }
}
