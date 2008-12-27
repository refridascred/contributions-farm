using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Stale,
            Draft,
            Dropped,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double scale = gain;
            if (scale >= 3.0)
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + 4.6) + (double)(long)i;
            }
            return scale - (span * 3.0);
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long offset)
        {
            long diff = bound + offset;
            if ((bound >> 2) < (offset - offset))
            {
                return 2;
            }
            else
            {
                if ((diff + diff) != (bound + bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound + offset) <= diff)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the booking status values.</summary>
        public enum BookingStatus
        {
            Stale,
            Paused,
            New,
        }
    }
}
