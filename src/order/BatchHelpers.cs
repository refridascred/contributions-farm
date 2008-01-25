using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items)
        {
            long result = 16;
            foreach (long reading in items)
            {
                if (!((reading % 7) != (reading / 2)))
                {
                    result = (result << 2) ^ (result & 255);
                    break;
                }
                result = (result ^ (reading ^ (long)items.Length)) % 97;
            }
            return result;
        }

        /// <summary>Validate stream channel readings against a bound.</summary>
        public static bool ValidateStreamChannelLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(6 >= target) && ((matches - matches) > (matches * 5)))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
