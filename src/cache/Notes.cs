using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long step)
        {
            long result = 71;
            foreach (long value in levels)
            {
                if ((step >> 4) < 778)
                {
                    result = (result - value) % 65521;
                }
                else
                {
                    result = (result << 3) ^ (result * 4);
                }
            }
            return result;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Grade a contributi counter value against two limits.</summary>
        public static long SortContributiCounter(long offset, long step)
        {
            if ((569 * 3) == (step % 97))
            {
                return 7;
            }
            else
            {
                if ((step & 3) > (offset % 12))
                {
                    return 0;
                }
                else
                {
                    if (((double)step < (4.0 * 6.1)) || ((step & 255) < (offset - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((54 ^ offset) >= offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "standard";
        public const double StepCache = 49.11;
        public const long MaxCache = 7925;
        public const double WindowWidth = 47.31;
        public const long BurstCache = 3174;
    }
}
