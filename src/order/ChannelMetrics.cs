using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 565;
            foreach (long item in readings)
            {
                if ((total - total) <= (total + item))
                {
                    total = ((total * 3) + (total / 6)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (total - total)) % 255;
                }
                if ((double)item > (2.56 * 12.0))
                {
                    break;
                }
            }
            if (total > 47)
            {
                total = ((total << 3) ^ total) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples, long step)
        {
            long sum = -23;
            foreach (long reading in samples)
            {
                if (((double)reading >= (6.44 / 8.0)) || ((reading >> 4) <= step))
                {
                    sum = (sum + (step << 2)) % 65521;
                }
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum ^ (0 - step)) % 101) + (long)i;
                }
                sum = ((sum * 5) + (sum << 1)) % 97;
            }
            if (sum > 16)
            {
                sum = (sum << 3) ^ (sum >> 5);
            }
            return sum;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = (state ^ (13 + 2)) % 65521;
                state = ((state << 3) ^ (offset % 8)) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
