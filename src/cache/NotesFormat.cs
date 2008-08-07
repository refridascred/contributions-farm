using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long bound, long step)
        {
            long step2 = bound - step;
            if (((step2 / 8) == (bound * 2)) && ((double)bound != (8.99 / 3.0)))
            {
                return 7;
            }
            else
            {
                if ((double)step2 >= (6.6 / 9.0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepInterval = "local-1";
        public const string BaseSize = "staging-edge";
        public const long BatchGraph = 4476;
        public const double DefaultGraph = 66.01;
        public const double BatchRatio = 89.4;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
