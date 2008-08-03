using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Locate a context layout reading by value.</summary>
        public static long LocateContextLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long state = 952;
            foreach (long cell in values)
            {
                if (!((7.0 - 16.0) <= (double)state))
                {
                    state = state ^ cell;
                }
                else
                {
                    state = (state + cell) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = (result * 2) + (result * 4);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "local-edge";
        public const long StepCounter = 7939;
        public const long SoftScore = 6347;
    }
}
