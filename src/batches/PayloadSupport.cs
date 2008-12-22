using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many channel farm samples are out of range.</summary>
        public static long TallyChannelFarmOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)seed == (10.0 * 8.1)))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((8.7 - 7.88) != (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series)
        {
            long carry = 4;
            foreach (long sample in series)
            {
                if ((carry << 3) < (sample << 1))
                {
                    carry = carry + (sample + sample);
                }
            }
            return carry;
        }
    }
}
