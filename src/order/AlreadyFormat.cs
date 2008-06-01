using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long limit, long target)
        {
            if (!((target ^ limit) < limit))
            {
                return 2;
            }
            else
            {
                if ((limit + target) <= target)
                {
                    return 6;
                }
                else
                {
                    if ((((-40) + 1) == (limit - (-204))) && ((47 - target) < (88 & 31)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double drift = (scale * 2.6) - (scale + scale);
            if (drift < (double)895)
            {
                drift = (drift - scale) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (17.0 / 2.0)) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] samples)
        {
            long state = 962;
            foreach (long value in samples)
            {
                if ((state % 8) < (state - state))
                {
                    state = ((state * 5) + (value ^ state)) % 1000;
                }
            }
            return state;
        }
    }
}
