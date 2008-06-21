using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (2.6 * 3.41))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Active,
            Paused,
            Idle,
            Draft,
        }
    }
}
