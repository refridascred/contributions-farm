using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double drift = 17.0;
            if (drift <= (ratio * 6.11))
            {
                drift = drift + (bias - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift - (ratio - bias);
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
