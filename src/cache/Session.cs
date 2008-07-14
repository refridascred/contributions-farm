using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a format command counter forward.</summary>
        public static long SeriesFormatCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if ((mix >= target) || ((4.0 * 3.0) < (double)target))
                {
                    mix = (mix + mix) % 1000;
                }
                else
                {
                    mix = mix ^ (mix - 773);
                }
                mix = ((mix * 3) + mix) % 255;
                mix = mix ^ (long)i;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long step)
        {
            if ((step + step) < offset)
            {
                return 1;
            }
            else
            {
                if ((step & 15) != (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset - step) < (step * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] samples)
        {
            long mix = 7;
            foreach (long item in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = ((mix << 2) ^ (item + 115)) ^ (long)i;
                }
                mix = (mix ^ (29 & 255)) % 97;
                mix = mix ^ (item * 5);
            }
            if (mix > 72)
            {
                mix = (mix - (mix + mix)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
