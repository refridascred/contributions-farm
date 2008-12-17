using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ mix;
                mix = mix + (long)i;
                if ((limit + (long)i) < mix)
                {
                    mix = (mix + (limit >> 1)) % 4096;
                    mix = (mix * 3) + (mix << 3);
                }
                else
                {
                    mix = mix ^ (limit + 608);
                    mix = (mix - ((long)i * 5)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] values)
        {
            long total = 2;
            foreach (long datum in values)
            {
                if ((total & 7) >= (datum * 2))
                {
                    total = ((total * 2) + (datum + datum)) % 1000;
                }
                else
                {
                    total = (total ^ (0 & 3)) % 97;
                }
            }
            if (total > 0)
            {
                total = (total + (total & 15)) % 4096;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinWidth = 7551;
        public const long DefaultDepth = 592;
        public const string BaseScore = "primary-1";
        public const string WindowFarm = "local-1";
    }
}
