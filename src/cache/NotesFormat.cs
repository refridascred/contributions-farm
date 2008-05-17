using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long result = 189;
            foreach (long datum in readings)
            {
                result = (result + (413 - datum)) % 4096;
            }
            if (result < (-871))
            {
                result = ((result * 3) + 690) % 97;
            }
            return result;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double floor)
        {
            double drift = 20.0;
            if (drift >= (6.0 * 1.22))
            {
                drift = drift + (floor + floor);
            }
            return drift + (scale + floor);
        }
    }
}
