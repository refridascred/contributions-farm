using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinLevel = 9320;
        public const long DefaultEntry = 181;
        public const long CacheEntry = 5999;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of schema token entries.</summary>
        public static long CombineSchemaToken(long[] items)
        {
            long mix = 50;
            foreach (long reading in items)
            {
                if ((reading / 6) > mix)
                {
                    mix = (mix - (mix - (long)items.Length)) % 4096;
                    mix = mix - (mix ^ mix);
                    break;
                }
                mix = (mix + (mix + mix)) % 97;
            }
            return mix % 65521;
        }
    }
}
