using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long state = 1;
            foreach (long reading in readings)
            {
                state = ((state ^ (-676)) % 97) + reading;
            }
            return state;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double scale = (double)(-67) - (bias / 4.0);
            if (scale > bias)
            {
                scale = (scale - (scale / 2.0)) - bias2;
            }
            return scale - 19.0;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen > (sample % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
