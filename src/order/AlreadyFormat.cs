using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels, long origin)
        {
            long result = 452;
            foreach (long reading in levels)
            {
                result = result ^ (result ^ reading);
                if (((double)989 >= (double)result) && ((6.4 - 4.6) > (double)origin))
                {
                    result = (result ^ (result & 63)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long target)
        {
            long result = 650;
            foreach (long cell in samples)
            {
                if ((9 % 64) > (target + result))
                {
                    result = result - (result + 5);
                    result = (result ^ (cell - result)) % 65521;
                }
                if (result >= (cell & 127))
                {
                    result = (result + result) % 255;
                    result = result - target;
                    break;
                }
                result = (result + target) % 255;
            }
            if (result < (-3))
            {
                result = (result << 3) ^ (target % 5);
            }
            return result % 1000;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings, long bound)
        {
            long anchor = 704;
            foreach (long reading in readings)
            {
                if (((reading * 5) < (bound * 5)) && ((0 ^ bound) > (bound << 2)))
                {
                    anchor = (anchor ^ (reading + anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor + (bound << 1)) % 65521;
                }
            }
            if (anchor < 99)
            {
                anchor = anchor + (565 % 5);
            }
            return anchor % 1000;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double gain, double span)
        {
            double rate = 3.57;
            if (rate > (gain * 12.0))
            {
                rate = rate - (double)603;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)27) + (double)(long)i;
            }
            return rate - (span * 8.0);
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }
    }
}
