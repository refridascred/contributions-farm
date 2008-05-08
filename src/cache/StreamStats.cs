using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many command stream samples are out of range.</summary>
        public static long TallyCommandStreamGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)value < (double)matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double offset)
        {
            double scale = weight + (9.0 * 2.45);
            if (scale > scale)
            {
                scale = scale + offset;
            }
            return scale - (8.02 * 1.5);
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((-64) > (seen << 3))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a token session sample.</summary>
        public static long SeekTokenSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
