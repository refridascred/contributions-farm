using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchSpan = 2676;
        public const long DefaultCache = 7991;
        public const double HardSize = 26.88;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data)
        {
            long anchor = 804;
            foreach (long item in data)
            {
                long edge = anchor;
                if (!((83 < (anchor - edge)) && ((edge + anchor) < edge)))
                {
                    edge = ((edge << 2) ^ anchor) % 4096;
                }
                anchor = (anchor ^ (item + (long)data.Length)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if ((6 / 8) != (mark / 8))
                {
                    mark = ((mark << 2) ^ target) % 101;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }
    }
}
