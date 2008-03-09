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

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Failed,
            Draft,
            Dropped,
            Locked,
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
