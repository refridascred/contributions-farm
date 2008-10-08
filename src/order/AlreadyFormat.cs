using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally >= value)
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((42 % 64) != (tally % 100))
                {
                    tally = ((tally + 1) + reading) - limit;
                }
            }
            return tally;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double load = bias * 4.4;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + load) + (double)(long)i) - span;
            }
            return load - 5.0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSpan = 922;
        public const double IdleRecord = 82.03;
        public const long WindowRecord = 9280;

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long origin)
        {
            if ((981 + 46) < seed)
            {
                return 2;
            }
            else
            {
                if (((origin + seed) != (origin - seed)) || ((origin >> 5) > (seed << 1)))
                {
                    return 0;
                }
                else
                {
                    if (((3.5 + 12.0) >= (double)seed) && ((2.5 + 15.0) >= (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed >> 1) >= (origin & 63))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
