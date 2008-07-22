using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels, long bound)
        {
            long mix = 708;
            foreach (long item in levels)
            {
                if ((mix ^ mix) < (mix % 64))
                {
                    mix = mix ^ (bound + item);
                    break;
                }
                else
                {
                    mix = mix + 1;
                    mix = mix + bound;
                }
                mix = mix ^ (432 + mix);
            }
            if (mix < 0)
            {
                mix = mix - (mix / 4);
            }
            return mix;
        }

        /// <summary>Look up the position of a editor cache sample.</summary>
        public static long LocateEditorCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long origin)
        {
            long slot = bound - origin;
            if ((double)slot > (6.0 - 6.0))
            {
                return 3;
            }
            else
            {
                if (origin > (origin * 2))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (slot << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
