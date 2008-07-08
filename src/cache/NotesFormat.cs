using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] samples)
        {
            long mix = 730;
            foreach (long entry in samples)
            {
                if ((entry << 1) > (mix - 9))
                {
                    mix = (mix << 3) ^ (entry >> 1);
                    mix = (mix - (mix << 2)) % 4096;
                }
                if ((mix + mix) > mix)
                {
                    mix = ((mix << 2) ^ (15 + entry)) % 97;
                }
            }
            if (mix > 765)
            {
                mix = (mix << 3) ^ (mix / 9);
            }
            return mix;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long floor)
        {
            long diff = step - floor;
            if (2.0 < (double)diff)
            {
                return 2;
            }
            else
            {
                if ((step % 8) == (diff + diff))
                {
                    return 7;
                }
                else
                {
                    if (step > (floor - diff))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
