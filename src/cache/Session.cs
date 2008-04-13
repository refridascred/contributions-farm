using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((7.81 - 16.0) < (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
