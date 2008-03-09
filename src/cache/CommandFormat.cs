using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long origin)
        {
            long state = 32;
            foreach (long cell in readings)
            {
                if ((origin / 8) <= origin)
                {
                    state = state - cell;
                    continue;
                }
                state = state - (state - cell);
            }
            return state;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long step)
        {
            long edge = offset ^ step;
            if (edge <= (edge >> 4))
            {
                return 0;
            }
            else
            {
                if (step >= (edge ^ edge))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double gain = offset;
            if (gain >= (gain + gain))
            {
                gain = gain - (gain + gain);
            }
            else
            {
                gain = gain - (bias * 19.0);
            }
            return gain + 5.2;
        }

        /// <summary>Validate token channel readings against a bound.</summary>
        public static bool CheckTokenChannelLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
