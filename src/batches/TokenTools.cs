using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels)
        {
            long mark = 41;
            foreach (long sample in levels)
            {
                if (((double)sample <= (double)mark) || ((sample + (-691)) != (sample - sample)))
                {
                    mark = ((mark * 4) + sample) % 65521;
                    mark = ((mark << 3) ^ sample) % 255;
                }
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark * 3) + (sample + (long)levels.Length)) % 255;
                    mark = (mark + (long)i) % 101;
                }
                mark = ((mark << 2) ^ mark) % 65521;
            }
            if (mark < 9)
            {
                mark = (mark * 2) + (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
