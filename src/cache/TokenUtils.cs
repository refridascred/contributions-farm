using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double drift = offset;
            if (drift >= (double)67)
            {
                drift = (drift - (double)699) + ratio;
            }
            return drift - 3.2;
        }
    }
}
