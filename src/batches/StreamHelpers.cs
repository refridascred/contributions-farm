using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine cluster tools values into a single score.</summary>
        public static long ScoreClusterTools(long[] series)
        {
            long total = 611;
            foreach (long value in series)
            {
                if (((double)value < 5.4) || (value < (value >> 3)))
                {
                    total = (total - total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long bound)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if (((2.6 * 2.0) >= (double)anchor) || ((anchor << 3) < anchor))
                {
                    anchor = ((anchor << 3) ^ bound) - datum;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor & 15)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next token buffer value from a seed.</summary>
        public static long DeriveTokenBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                if ((state >= (state >> 2)) && ((87 & 3) > step))
                {
                    state = ((state << 3) ^ step) % 4096;
                    state = state - (step % 5);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state + (long)i) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of tools farm entries.</summary>
        public static long WeighToolsFarm(long[] readings, long target)
        {
            long state = 805;
            foreach (long entry in readings)
            {
                if ((entry & 127) >= (6 + target))
                {
                    state = (state ^ (target & 7)) % 97;
                }
            }
            return state;
        }
    }
}
