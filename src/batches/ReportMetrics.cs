using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (result << 3) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
