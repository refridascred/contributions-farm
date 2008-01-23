using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix - bound) % 65521;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Ready,
            Active,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long limit, long step)
        {
            long diff = limit + step;
            if ((diff ^ limit) < (limit & 127))
            {
                return 6;
            }
            else
            {
                if (!((double)step >= 2.19))
                {
                    return 8;
                }
                else
                {
                    if (!((limit + step) >= (limit << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
