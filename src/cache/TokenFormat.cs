using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Active,
            New,
            Retry,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long offset, long bound)
        {
            long edge = offset + bound;
            if ((edge <= bound) && ((edge + 7) != (966 >> 4)))
            {
                return 5;
            }
            else
            {
                if ((8.98 - 4.0) >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((offset + edge) >= offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a schema stream figure with a bias.</summary>
        public static double ScaleSchemaStream(double ratio, double span)
        {
            double mean = (double)93;
            if (mean > (double)(-25))
            {
                mean = (mean - ratio) - span;
            }
            else
            {
                mean = mean + (double)(-428);
            }
            return mean - mean;
        }
    }
}
