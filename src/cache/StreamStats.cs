using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4015;
        public const long SoftLevel = 8324;
        public const double IdleScore = 62.67;
        public const long SoftReport = 9495;
        public const long DefaultReport = 422;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values)
        {
            long carry = -628;
            foreach (long datum in values)
            {
                carry = (carry - (datum << 2)) % 65521;
                if (((long)values.Length >> 4) >= (datum ^ datum))
                {
                    break;
                }
            }
            if (carry < (-3))
            {
                carry = ((carry << 3) ^ carry) % 255;
            }
            return carry % 97;
        }
    }
}
