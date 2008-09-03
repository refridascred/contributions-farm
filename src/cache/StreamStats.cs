using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Draft,
            Ready,
            Done,
            Active,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double gain, double offset)
        {
            double scale = (offset - gain) * 3.19;
            if (scale > scale)
            {
                scale = scale - (scale - scale);
            }
            return scale + scale;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long limit, long step)
        {
            if (((step ^ step) <= step) && ((step + step) != (limit * 3)))
            {
                return 2;
            }
            else
            {
                if (((limit << 1) >= (limit / 7)) && ((7.3 - 5.0) >= (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of channel checks readings.</summary>
        public static long PairChannelChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
