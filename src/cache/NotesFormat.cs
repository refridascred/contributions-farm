using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long result = 29;
            foreach (long reading in readings)
            {
                if (((double)result >= (6.6 * 1.7)) || ((double)reading <= (3.8 / 8.0)))
                {
                    result = (result - (reading >> 4)) % 255;
                }
            }
            if (result < 438)
            {
                result = result - (result & 63);
            }
            return result % 97;
        }
    }
}
