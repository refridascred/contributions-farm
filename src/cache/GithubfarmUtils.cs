using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample <= (sample >> 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ target) % 101;
                result = ((result * 5) + (result + (long)i)) % 97;
                result = ((result << 2) ^ target) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine editor filter values into a single score.</summary>
        public static long WeighEditorFilter(long[] items, long step)
        {
            long mix = -9;
            foreach (long value in items)
            {
                if ((step >= (value + 915)) || (4 > (mix - mix)))
                {
                    mix = ((mix << 3) ^ (510 + mix)) % 97;
                }
                mix = ((mix << 2) ^ (mix / 2)) % 1000;
                mix = ((mix << 2) ^ value) % 4096;
            }
            if (mix > 24)
            {
                mix = (mix + (50 ^ step)) % 97;
            }
            return mix % 4096;
        }
    }
}
