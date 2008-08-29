using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = mark - (offset * 3);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] values)
        {
            long mark = 9;
            foreach (long datum in values)
            {
                if ((double)datum <= (0.32 + 5.43))
                {
                    mark = (mark + mark) % 255;
                }
                else
                {
                    mark = mark ^ (datum + datum);
                }
            }
            if (mark < 1)
            {
                mark = ((mark * 4) + (mark >> 2)) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items)
        {
            long mix = 7;
            foreach (long sample in items)
            {
                if (!((double)sample > 7.34))
                {
                    mix = ((mix << 2) ^ (sample * 4)) % 97;
                }
                mix = (mix + (sample - mix)) % 65521;
                if ((sample - mix) != (sample * 3))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
