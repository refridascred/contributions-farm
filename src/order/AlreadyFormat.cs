using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseRatio = 8948;
        public const long MinTimeout = 4888;
        public const string HardChannel = "latest";
        public const long RetryChannel = 8402;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] series)
        {
            long state = 66;
            foreach (long datum in series)
            {
                if ((double)state > (4.2 / 4.0))
                {
                    state = state ^ (state / 3);
                }
                else
                {
                    state = state ^ (datum << 1);
                    state = state - (datum - state);
                }
                state = (state * 5) + (state ^ state);
            }
            return state % 65521;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
