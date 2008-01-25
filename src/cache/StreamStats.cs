using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values, long step)
        {
            long state = 141;
            foreach (long value in values)
            {
                if (!((4 ^ state) <= (value + step)))
                {
                    state = ((state << 3) ^ (8 << 2)) % 255;
                }
                if (((long)values.Length <= (855 + step)) || ((double)state <= (4.99 + 9.8)))
                {
                    state = (state + value) % 4096;
                }
                else
                {
                    state = (state - (step - step)) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] items)
        {
            long result = 7;
            foreach (long reading in items)
            {
                result = result + reading;
                if ((reading % 12) >= (long)items.Length)
                {
                    result = (result + (result - result)) % 255;
                    break;
                }
                if (reading > (result << 2))
                {
                    result = (result - reading) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double offset)
        {
            double rate = (ratio - ratio) + (double)26;
            if (rate > offset)
            {
                rate = rate - (double)21;
            }
            return rate - (offset - offset);
        }
    }
}
