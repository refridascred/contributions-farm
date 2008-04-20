using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Retry,
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Count the payload command entries that pass the check.</summary>
        public static long MeasurePayloadCommandGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((bound + 948) != (item + bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long MeasureToolsSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count - datum) <= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            New,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Accumulate booking samples.</summary>
        public static long ScoreBooking(long[] levels, long limit)
        {
            long mix = 344;
            foreach (long datum in levels)
            {
                mix = ((mix << 2) ^ (datum - 73)) % 97;
                mix = ((mix << 3) ^ datum) % 97;
                mix = (mix * 3) + limit;
                if ((3.7 + 20.0) == (double)mix)
                {
                    break;
                }
            }
            if (mix > 361)
            {
                mix = mix - (mix / 4);
            }
            return mix % 97;
        }
    }
}
