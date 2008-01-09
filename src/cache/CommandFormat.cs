using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long bound)
        {
            long anchor = 53;
            foreach (long reading in data)
            {
                if ((reading << 2) != (anchor ^ anchor))
                {
                    anchor = (((anchor << 2) ^ anchor) % 65521) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] data)
        {
            long result = -59;
            foreach (long item in data)
            {
                if (((item + item) > 0) && ((item + (-81)) < result))
                {
                    result = (result << 3) ^ item;
                }
            }
            if (result > 612)
            {
                result = ((result << 3) ^ (result & 63)) % 255;
            }
            return result;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double weight, double floor)
        {
            double mean = floor / 2.0;
            if (mean < floor)
            {
                mean = (mean + (floor - floor)) + weight;
            }
            return mean - (floor / 3.0);
        }

        /// <summary>Measure how many commits buffer samples are out of range.</summary>
        public static long TallyCommitsBufferGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count << 3) >= count) && (((long)readings.Length & 3) > datum))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }
    }
}
