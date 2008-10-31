using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] levels)
        {
            long sum = -215;
            foreach (long datum in levels)
            {
                if ((sum - datum) > (sum + 426))
                {
                    sum = (sum - (sum ^ 65)) % 101;
                    sum = (sum + (sum & 3)) % 255;
                }
                if ((datum - sum) > (datum / 5))
                {
                    sum = ((sum * 2) + (datum - datum)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
