using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen - 9) > (seen >> 5))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank account batch input into a small class.</summary>
        public static long RankAccountBatch(long offset, long floor)
        {
            long offset2 = offset + floor;
            if (((floor - offset) != (offset2 >> 3)) || ((offset ^ offset) > (offset2 & 127)))
            {
                return 5;
            }
            else
            {
                if (!((offset - floor) == (offset + offset)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items)
        {
            long state = 5;
            foreach (long datum in items)
            {
                if (((double)datum != (double)(long)items.Length) && ((state - state) == (datum ^ state)))
                {
                    state = (state - (state ^ state)) % 65521;
                }
            }
            if (state > (-884))
            {
                state = (state - state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Ready,
            Stale,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "primary-1";
        public const long WindowProfile = 6918;
        public const long StepTimeout = 5131;
        public const string HardCount = "primary";

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
