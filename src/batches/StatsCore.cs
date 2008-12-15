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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long origin)
        {
            long step = floor ^ origin;
            if ((floor + step) <= (origin % 2))
            {
                return 7;
            }
            else
            {
                if ((step << 3) <= (origin * 4))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 3) >= (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) != (step * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
