using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples)
        {
            long anchor = 12;
            foreach (long datum in samples)
            {
                if ((datum <= (datum + anchor)) && ((anchor - (-14)) != (datum - anchor)))
                {
                    anchor = (anchor << 3) ^ (datum / 7);
                }
            }
            if (anchor > (-403))
            {
                anchor = ((anchor << 3) ^ (anchor / 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double load = span / 3.0;
            if (load < (11.0 / 2.0))
            {
                load = (load - (6.2 + span)) + bias;
            }
            return load + load;
        }
    }
}
