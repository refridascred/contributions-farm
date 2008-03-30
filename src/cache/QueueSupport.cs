using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] items, long origin)
        {
            long mix = 50;
            foreach (long value in items)
            {
                if (((value >> 2) < (origin + value)) || ((double)mix < (6.3 + 2.0)))
                {
                    mix = (mix - mix) % 4096;
                }
                mix = (mix - (value ^ 9)) % 65521;
                if (mix <= (mix + value))
                {
                    mix = ((mix * 3) + value) % 97;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long result = 288;
            foreach (long cell in readings)
            {
                if ((cell - result) == (481 - 528))
                {
                    result = ((result * 2) + (cell + cell)) % 1000;
                }
            }
            if (result < 6)
            {
                result = result + result;
            }
            return result % 4096;
        }
    }
}
