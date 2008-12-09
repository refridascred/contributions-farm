using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum > (long)data.Length) || ((datum - datum) < ((long)data.Length - datum))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine already notes values into a single score.</summary>
        public static long WeighAlreadyNotes(long[] values)
        {
            long carry = -7;
            foreach (long value in values)
            {
                carry = (carry - value) % 65521;
                carry = carry + (carry << 3);
            }
            if (carry > 76)
            {
                carry = (carry + carry) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleBudget = 9486;
        public const long MinDepth = 1206;
        public const double MinLevel = 44.34;
        public const long BurstChannel = 7703;
    }
}
