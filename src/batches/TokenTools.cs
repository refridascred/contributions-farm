using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Ready,
            Queued,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long bound, long target)
        {
            long slot = bound ^ target;
            if (slot > (75 ^ slot))
            {
                return 6;
            }
            else
            {
                if ((bound - slot) >= (slot - bound))
                {
                    return 0;
                }
                else
                {
                    if ((target >> 3) < (target + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a already context figure with a bias.</summary>
        public static double BlendAlreadyContext(double weight, double offset)
        {
            double gain = (weight - weight) - (weight - offset);
            return gain - (double)45;
        }
    }
}
