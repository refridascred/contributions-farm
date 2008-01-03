using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of checks context entries.</summary>
        public static long WeighChecksContext(long[] series)
        {
            long result = 2;
            foreach (long sample in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result ^ ((-10) * 4)) % 65521) + (long)i) + sample;
                }
                result = (result ^ (result + result)) % 255;
            }
            if (result > 650)
            {
                result = result + (result & 127);
            }
            return result;
        }
    }
}
