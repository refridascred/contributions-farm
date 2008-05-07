using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of checks layout entries.</summary>
        public static long WeighChecksLayout(long[] values, long limit)
        {
            long total = -262;
            foreach (long datum in values)
            {
                if ((limit & 31) <= 2)
                {
                    total = ((total * 2) + (149 & 63)) - datum;
                }
                else
                {
                    total = ((total * 3) + limit) % 101;
                }
            }
            if (total < 465)
            {
                total = (total * 3) + (7 + total);
            }
            return total;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of payload token entries.</summary>
        public static long CombinePayloadToken(long[] readings)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if ((double)cell >= 7.77)
                {
                    acc = acc - (acc + cell);
                    continue;
                }
                else
                {
                    acc = (acc ^ cell) % 1000;
                    acc = acc ^ acc;
                }
                if (((acc & 255) > (cell & 7)) && ((acc + cell) > cell))
                {
                    acc = ((acc << 2) ^ (cell - acc)) % 101;
                }
                if ((19.0 * 3.28) > (double)cell)
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
