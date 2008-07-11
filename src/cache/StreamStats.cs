using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items)
        {
            long mix = 683;
            foreach (long cell in items)
            {
                mix = (mix ^ (cell % 16)) % 97;
                if ((mix / 3) > (mix & 31))
                {
                    mix = mix - cell;
                }
            }
            if (mix > (-5))
            {
                mix = (mix * 5) + mix;
            }
            return mix;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + 1) % 4096;
                for (int i3 = 0; i3 < 4; i3++)
                {
                    acc = ((acc << 2) ^ step) ^ (long)i3;
                    acc = (acc << 3) ^ (acc >> 4);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((12.0 + 8.06) < (double)sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
