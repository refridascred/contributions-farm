using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double bias2)
        {
            double rate = (double)(-73) / 2.0;
            if (rate > bias)
            {
                rate = (rate - (rate * 4.9)) + bias2;
            }
            return rate - (bias / 4.0);
        }
    }
}
