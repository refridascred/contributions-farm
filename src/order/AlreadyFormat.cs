using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] items, long target)
        {
            long mix = 8;
            foreach (long entry in items)
            {
                if ((target << 1) >= target)
                {
                    mix = ((mix << 2) ^ (entry / 9)) % 255;
                }
                else
                {
                    mix = mix + (mix - target);
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
