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

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long mix = -55;
            foreach (long sample in values)
            {
                if ((mix / 3) < (-930))
                {
                    mix = (mix * 4) + (sample * 5);
                }
            }
            if (mix > 85)
            {
                mix = (mix - mix) % 4096;
            }
            return mix % 97;
        }
    }
}
