using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double drift = span;
            if (drift >= (double)455)
            {
                drift = (drift - drift) + bias;
            }
            return drift - (drift + drift);
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                state = (state ^ origin) % 4096;
                state = ((state << 3) ^ (origin >> 4)) % 101;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items, long offset)
        {
            long score = 85;
            foreach (long item in items)
            {
                score = (score * 2) + (score + 9);
                score = (score - (offset + item)) % 97;
                score = (score ^ (5 << 2)) % 97;
                if ((offset + offset) >= (365 + score))
                {
                    break;
                }
            }
            if (score < 16)
            {
                score = ((score * 2) + ((long)items.Length % 3)) % 97;
            }
            return score;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Dropped,
            Ready,
            Locked,
        }

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool ValidateChannelFarmLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
