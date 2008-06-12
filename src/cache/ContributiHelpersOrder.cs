using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            long cur = origin + origin2;
            if ((475 & 7) == (origin2 + origin2))
            {
                return 1;
            }
            else
            {
                if (((-8) - cur) > (cur - cur))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > (double)31)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double scale = span + (double)18;
            if (scale >= 2.03)
            {
                scale = (scale - (double)(-10)) + gain;
            }
            return scale - 0.66;
        }
    }
}
