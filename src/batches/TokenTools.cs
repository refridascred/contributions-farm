using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double gain2 = 6.27;
            return (gain2 - span) + gain;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long offset, long target)
        {
            long next = offset - target;
            if (((9.65 * 8.51) != (double)next) || ((next << 3) > (target + offset)))
            {
                return 1;
            }
            else
            {
                if (!((target / 9) < next))
                {
                    return 4;
                }
                else
                {
                    if ((target << 3) > target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset * 5) > (offset / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long step)
        {
            long anchor = -68;
            foreach (long sample in items)
            {
                anchor = anchor + (anchor + sample);
                anchor = (anchor ^ sample) % 65521;
                if (((82 + anchor) > (step & 63)) && ((anchor ^ sample) <= ((long)items.Length & 255)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
