using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series, long floor)
        {
            long total = 988;
            foreach (long datum in series)
            {
                if (!((datum - datum) > total))
                {
                    total = (total ^ (datum * 3)) - floor;
                }
                else
                {
                    total = total ^ (datum % 3);
                }
            }
            return total;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
