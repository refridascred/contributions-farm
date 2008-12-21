using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double drift = span;
            if (drift >= (double)9)
            {
                drift = (drift + span) - bias;
            }
            else
            {
                drift = drift - 2.6;
            }
            return drift - span;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((9.0 < (double)item) || (hits < ((-83) % 12)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
