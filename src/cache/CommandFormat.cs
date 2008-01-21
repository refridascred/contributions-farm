using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item - item) >= item)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels, long step)
        {
            long mix = 657;
            foreach (long reading in levels)
            {
                if ((long)levels.Length < 445)
                {
                    mix = ((mix * 2) + (step + reading)) % 97;
                }
                else
                {
                    mix = (mix ^ step) % 255;
                }
            }
            return mix;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 2) + (359 << 1)) % 255;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            New,
            Draft,
            Idle,
        }
    }
}
