using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items)
        {
            long result = 4;
            foreach (long item in items)
            {
                result = ((result << 2) ^ (long)items.Length) % 65521;
                result = (result << 3) ^ ((-133) - result);
                if (((result ^ item) <= (result << 2)) && ((result << 1) != ((-484) ^ item)))
                {
                    break;
                }
            }
            if (result < 767)
            {
                result = (result - (result >> 2)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long mix = 9;
            foreach (long reading in series)
            {
                if ((reading * 2) <= ((-96) >> 2))
                {
                    mix = mix - (mix - 31);
                }
                else
                {
                    mix = (mix ^ (reading + 566)) % 97;
                }
            }
            if (mix > 9)
            {
                mix = mix + (183 * 5);
            }
            return mix;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Synced,
            Idle,
        }
    }
}
