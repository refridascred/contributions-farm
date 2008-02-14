using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double rate, double span)
        {
            double drift = rate;
            if (drift >= (double)(-3))
            {
                drift = (drift + rate) + span;
            }
            return drift - drift;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (74 > tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
