using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate session window readings against a bound.</summary>
        public static bool VerifySessionWindowRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum - matches) >= (limit - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double mean = (double)9 * 6.0;
            if (mean < (scale / 5.0))
            {
                mean = (mean - (mean / 3.0)) - offset;
            }
            return mean - (double)363;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
