using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a farm buffer counter forward.</summary>
        public static long RollFarmBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i + step) > 182)
                {
                    mix = mix - (mix + (long)i);
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((double)seen > (17.0 + 16.0)) && (((seen / 5) != (sample + seen)) && ((seen % 7) > (931 ^ seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data)
        {
            long acc = 151;
            foreach (long cell in data)
            {
                if (!((double)cell < (1.0 + 19.0)))
                {
                    acc = (acc - cell) % 4096;
                }
            }
            if (acc < (-11))
            {
                acc = ((acc * 3) + (acc + acc)) % 97;
            }
            return acc % 97;
        }
    }
}
