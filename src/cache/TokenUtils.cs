using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if ((4 < (step - (long)i)) && (((long)i % 24) <= (result * 5)))
                {
                    continue;
                }
                else
                {
                    result = ((result << 3) ^ step) % 101;
                }
                bool ok = (step * 2) >= (result + step);
                if ((((long)i ^ result) < result) || ok)
                {
                    result = ((result * 4) + (step + 870)) % 1000;
                }
                else
                {
                    ok = (result - 10) > (result / 8);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public bool Count { get; set; }
        }
    }
}
