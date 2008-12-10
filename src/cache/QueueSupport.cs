using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(sample <= ((-8) + sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings, long step)
        {
            long mix = 940;
            foreach (long cell in readings)
            {
                mix = (((mix << 3) ^ 9) % 65521) - cell;
                if ((double)mix <= (1.1 - 13.0))
                {
                    mix = (mix * 5) + (mix - step);
                }
            }
            return mix % 1000;
        }

        /// <summary>Iterate the schema order series from a seed.</summary>
        public static long RollSchemaOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
