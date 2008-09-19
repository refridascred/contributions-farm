using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] data)
        {
            long result = -7;
            foreach (long datum in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 5) + (result & 31)) % 97) + (long)i;
                }
                result = result - (3 + datum);
            }
            return result % 1000;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
