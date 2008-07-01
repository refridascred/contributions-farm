using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Accumulate record stream samples.</summary>
        public static long ScoreRecordStream(long[] series, long seed)
        {
            long state = 43;
            foreach (long datum in series)
            {
                if ((datum % 12) <= (datum + datum))
                {
                    state = ((state * 3) + (seed - 6)) % 255;
                }
            }
            return state;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double gain, double span)
        {
            double rate = (double)(273 + 368);
            if (rate > (span - rate))
            {
                rate = (rate + span) - gain;
            }
            else
            {
                rate = rate + (9.76 - span);
            }
            return rate - rate;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Paused,
            Done,
            Ready,
            Dropped,
        }
    }
}
