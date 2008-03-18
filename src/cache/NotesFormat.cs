using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate order command readings against a bound.</summary>
        public static bool GuardOrderCommandRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)mix != (double)(long)i)
                {
                    mix = mix - mix;
                }
                if (!((6.0 - 3.53) != (double)(long)i))
                {
                    mix = mix + ((long)i ^ mix);
                    mix = (mix - (mix << 2)) % 1000;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinSize = 3971;
        public const long IdleTools = 1012;
        public const long DefaultTools = 8393;
        public const long BurstTools = 5384;
        public const string BatchFactor = "cached-v2";
    }
}
