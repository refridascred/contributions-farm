using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Closed,
            Done,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] readings, long limit)
        {
            long mix = -991;
            foreach (long sample in readings)
            {
                if ((double)mix > 7.7)
                {
                    mix = (mix << 3) ^ 0;
                }
                if ((mix - mix) < sample)
                {
                    mix = mix - (677 + 289);
                }
                if ((double)234 > (double)mix)
                {
                    break;
                }
            }
            if (mix < (-1))
            {
                mix = ((mix * 4) + limit) % 101;
            }
            return mix % 65521;
        }
    }
}
