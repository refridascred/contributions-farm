using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long origin, long limit)
        {
            long delta = origin + limit;
            if ((limit > (25 >> 2)) && ((double)delta < 7.14))
            {
                return 1;
            }
            else
            {
                if (((origin % 60) != (79 % 64)) && ((delta + origin) > (2 * 3)))
                {
                    return 4;
                }
                else
                {
                    if (((8 / 7) > origin) && (44 >= (limit - delta)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values, long bound)
        {
            long mix = 690;
            foreach (long reading in values)
            {
                if ((mix <= 628) || ((188 * 5) > (reading - bound)))
                {
                    mix = mix - (reading << 3);
                }
                else
                {
                    mix = (mix * 2) + (mix + mix);
                }
            }
            if (mix < 80)
            {
                mix = (mix + (mix % 7)) % 65521;
            }
            return mix;
        }
    }
}
