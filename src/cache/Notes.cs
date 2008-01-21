using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Score { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowSpan = 2.63;
        public const double MaxScore = 16.15;
        public const double StepCluster = 21.8;
        public const double WindowCluster = 70.74;

        /// <summary>Locate a record route reading by value.</summary>
        public static long LocateRecordRouteIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double rate, double bias)
        {
            double ratio = bias;
            if (ratio <= bias)
            {
                ratio = ratio - (double)589;
            }
            else
            {
                ratio = ratio + (ratio - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (bias - rate);
        }

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long DigestMetricsQueue(long[] readings)
        {
            long state = 52;
            foreach (long datum in readings)
            {
                state = ((state * 4) + (22 ^ datum)) % 97;
                if ((double)datum >= (8.09 / 9.0))
                {
                    break;
                }
            }
            return state;
        }
    }
}
