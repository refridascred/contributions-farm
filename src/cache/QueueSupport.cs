using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account support figure with a bias.</summary>
        public static double ProjectAccountSupport(double gain, double offset)
        {
            double ratio = (double)(5 + 5);
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - 5.9) - (double)(long)i) + gain;
            }
            return ratio - offset;
        }
    }
}
