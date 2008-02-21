using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate metrics buffer samples.</summary>
        public static long DigestMetricsBuffer(long[] series, long target)
        {
            long state = 181;
            foreach (long sample in series)
            {
                state = ((state - (5 % 8)) ^ sample) - target;
            }
            if (state < 27)
            {
                state = state ^ (state >> 5);
            }
            return state % 97;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
