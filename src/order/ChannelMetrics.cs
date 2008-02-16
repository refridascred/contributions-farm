using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels, long origin)
        {
            long result = 13;
            foreach (long cell in levels)
            {
                if ((cell ^ origin) > (result >> 1))
                {
                    result = result ^ (cell + cell);
                }
                else
                {
                    result = ((result * 5) + (-206)) % 97;
                }
                result = result + cell;
                if ((result & 127) > (670 & 63))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
