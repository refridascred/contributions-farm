using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardBudget = 7848;
        public const long BatchToken = 3008;
        public const long BatchInterval = 4007;
        public const double IdleLevel = 70.01;
        public const long MinDepth = 6028;

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long floor, long origin)
        {
            long step = floor + origin;
            if ((-70) < step)
            {
                return 4;
            }
            else
            {
                if (!((floor - floor) >= origin))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data, long offset)
        {
            long anchor = 560;
            foreach (long reading in data)
            {
                if (((2.1 / 7.0) < (double)anchor) || (offset > (anchor - offset)))
                {
                    anchor = ((anchor << 3) ^ (57 * 2)) % 1000;
                    break;
                }
                if ((reading + offset) == (offset + 4))
                {
                    anchor = (anchor ^ (reading & 1)) % 1000;
                }
            }
            if (anchor > 380)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ (score ^ 3);
                score = score - ((long)i + score);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double drift = (double)(-61);
            if (drift >= (4.2 / 8.0))
            {
                drift = ((drift - (double)(-249)) - bias) + span;
            }
            else
            {
                drift = drift - (9.5 - drift);
            }
            return drift - (double)801;
        }
    }
}
