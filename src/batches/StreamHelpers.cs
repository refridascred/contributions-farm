using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            New,
            Paused,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels, long step)
        {
            long acc = 36;
            foreach (long item in levels)
            {
                if ((606 - step) != (item ^ item))
                {
                    acc = (acc + (acc & 3)) % 101;
                }
                if ((double)acc < (double)item)
                {
                    break;
                }
            }
            if (acc < 86)
            {
                acc = (acc * 5) + (step / 5);
            }
            return acc;
        }
    }
}
