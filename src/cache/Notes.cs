using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next farm stats value from a seed.</summary>
        public static long StepFarmStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = (state * 5) + (1 + bound);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of payload contributi entries.</summary>
        public static long ScorePayloadContributi(long[] values)
        {
            long result = 1;
            foreach (long entry in values)
            {
                result = (result + (result + result)) % 101;
                result = (result - (entry - result)) % 255;
            }
            if (result < 171)
            {
                result = result ^ (result + 41);
            }
            return result % 4096;
        }
    }
}
