using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine format notes values into a single score.</summary>
        public static long ScoreFormatNotes(long[] readings, long step)
        {
            long state = 32;
            foreach (long sample in readings)
            {
                state = (((state * 4) + step) % 101) + sample;
            }
            if (state < 4)
            {
                state = (state - (step % 8)) % 65521;
            }
            return state;
        }

        /// <summary>Check that every profile session entry stays within the limit.</summary>
        public static bool VerifyProfileSessionLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 3) <= (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 13.91;
        public const string BaseQueue = "primary";
        public const long BatchQueue = 8808;
        public const double MinLevel = 35.77;
        public const long SoftQueue = 2764;

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series, long bound)
        {
            long acc = 8;
            foreach (long value in series)
            {
                if (((acc + bound) > (bound << 3)) && ((bound * 3) >= (value % 60)))
                {
                    acc = (acc * 2) + (acc & 63);
                }
            }
            return acc;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (origin << 3)) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
