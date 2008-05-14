using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a already account value against two limits.</summary>
        public static long GradeAlreadyAccount(long seed, long step)
        {
            if ((seed * 3) <= seed)
            {
                return 3;
            }
            else
            {
                if ((seed << 3) >= (step + seed))
                {
                    return 4;
                }
                else
                {
                    if ((step / 5) <= (step & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed < (7.8 * 12.0)) && ((step + step) >= step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count == (7.0 * 5.6))
                {
                    count = ((count + 1) + reading) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double bias, double offset)
        {
            double scale = offset;
            if (scale > (4.5 / 3.0))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - 11.0) + (double)(long)i;
            }
            return scale + (bias / 9.0);
        }
    }
}
