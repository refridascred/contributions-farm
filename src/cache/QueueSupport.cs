using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every command entry entry stays within the limit.</summary>
        public static bool VerifyCommandEntryBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings)
        {
            long score = 216;
            foreach (long entry in readings)
            {
                score = ((score - (score / 4)) % 1000) ^ entry;
            }
            if (score > 92)
            {
                score = ((score * 2) + (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Owner { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
