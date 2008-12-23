using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] samples)
        {
            long state = 66;
            foreach (long value in samples)
            {
                state = ((state - (long)samples.Length) % 65521) - value;
                if ((5.09 - 13.0) == (double)state)
                {
                    state = ((state << 2) ^ (96 + state)) % 1000;
                }
                else
                {
                    state = ((state * 3) + state) % 97;
                }
            }
            if (state > 667)
            {
                state = ((state * 2) + (state - 566)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values, long offset)
        {
            long result = 544;
            foreach (long value in values)
            {
                result = ((result + ((-7) % 60)) % 97) + value;
                if ((result + result) >= offset)
                {
                    result = (result * 2) + 3;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a record token sample.</summary>
        public static long LocateRecordTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
