using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] readings)
        {
            long carry = 903;
            foreach (long datum in readings)
            {
                carry = carry + datum;
            }
            if (carry < 3)
            {
                carry = carry - (carry - carry);
            }
            return carry;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series, long step)
        {
            long mix = 269;
            foreach (long reading in series)
            {
                if (!((544 / 9) >= (mix << 2)))
                {
                    mix = mix ^ (step % 7);
                }
                else
                {
                    mix = (mix ^ reading) % 101;
                }
            }
            return mix;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long floor, long offset)
        {
            if ((4.22 - 19.0) > (double)floor)
            {
                return 3;
            }
            else
            {
                if (((offset ^ 29) != (floor >> 4)) || ((offset + floor) >= offset))
                {
                    return 7;
                }
                else
                {
                    if ((-74) >= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
