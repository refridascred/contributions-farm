using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long step, long offset)
        {
            long offset2 = step + offset;
            if ((543 + step) > (411 - offset2))
            {
                return 0;
            }
            else
            {
                if ((1.1 - 19.0) <= (double)offset2)
                {
                    return 5;
                }
                else
                {
                    if ((offset2 & 127) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset2 & 1) > (offset % 97)) || ((offset2 << 1) >= offset2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of editor metric entries.</summary>
        public static long TotalEditorMetric(long[] data)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if (state <= (state - state))
                {
                    break;
                }
                else
                {
                    state = ((state * 5) + 605) % 4096;
                    state = (state + (sample << 3)) % 101;
                }
                if ((state - state) != (252 >> 1))
                {
                    state = state - (340 + sample);
                }
            }
            return state % 4096;
        }
    }
}
