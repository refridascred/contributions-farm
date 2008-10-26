using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((5.2 - 2.57) != (double)matches) || ((value + target) == (matches + value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double ratio, double floor)
        {
            double gain = floor;
            if (gain > (double)777)
            {
                gain = (gain - 20.0) - ratio;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings, long bound)
        {
            long carry = -52;
            foreach (long value in readings)
            {
                if (!(3 <= (bound - (-8))))
                {
                    carry = (carry * 3) + (bound + value);
                }
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
