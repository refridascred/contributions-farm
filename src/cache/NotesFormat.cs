using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((long)samples.Length < (688 - hits)))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Roll a stream token counter forward.</summary>
        public static long IterateStreamToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ (floor + mix)) % 255;
                if ((double)584 < (double)(long)i)
                {
                    mix = mix ^ (floor & 7);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
