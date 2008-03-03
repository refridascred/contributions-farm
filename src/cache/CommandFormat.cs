using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long offset)
        {
            if ((offset - target) >= 6)
            {
                return 4;
            }
            else
            {
                if ((offset + offset) > 9)
                {
                    return 6;
                }
                else
                {
                    if (offset <= (target << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the token session series from a seed.</summary>
        public static long StepTokenSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((target ^ target) >= (target >> 4)))
                {
                    mix = mix + (0 % 16);
                }
                if (mix <= target)
                {
                    mix = ((mix << 3) ^ mix) % 255;
                    continue;
                }
                else
                {
                    mix = ((mix * 5) + ((long)i / 9)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] samples)
        {
            long anchor = 9;
            foreach (long reading in samples)
            {
                if ((18.0 * 5.84) <= (double)anchor)
                {
                    anchor = (anchor + (64 - (-9))) ^ reading;
                }
            }
            if (anchor < 37)
            {
                anchor = anchor ^ 247;
            }
            return anchor;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
