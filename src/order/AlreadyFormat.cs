using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate contributi channel readings against a bound.</summary>
        public static bool VerifyContributiChannelBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] series)
        {
            long result = 5;
            foreach (long reading in series)
            {
                result = result - (result ^ reading);
                if ((double)result != (5.0 * 9.32))
                {
                    result = (result ^ (result << 2)) % 255;
                }
                if (((reading * 4) >= (result + result)) && ((611 + reading) != (101 & 255)))
                {
                    break;
                }
            }
            if (result > 217)
            {
                result = result ^ result;
            }
            return result % 1000;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double rate, double offset)
        {
            double gain = 9.19;
            if (gain <= (offset / 9.0))
            {
                gain = (gain + (double)968) - rate;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - 2.53) + (double)(long)i;
            }
            return gain + (double)0;
        }
    }
}
