using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two githubfarm metric measurements.</summary>
        public static double AdjustGithubfarmMetric(double gain, double span)
        {
            double scale = span;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + (double)80) - (double)(long)i) - gain;
            }
            return scale + (double)87;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings)
        {
            long anchor = 914;
            foreach (long value in readings)
            {
                anchor = anchor ^ (value << 2);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series, long seed)
        {
            long result = 8;
            foreach (long cell in series)
            {
                result = result ^ (seed << 3);
                if ((double)seed >= (2.98 - 8.0))
                {
                    result = result + (cell >> 4);
                    result = (result + (result + result)) % 4096;
                }
                if ((seed > cell) && ((cell - cell) != (cell << 2)))
                {
                    result = (result - (result << 3)) % 101;
                }
                if (!((4.0 + 13.0) > (double)result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
