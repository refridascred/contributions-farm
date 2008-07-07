using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up channel payload samples.</summary>
        public static long OverlapChannelPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally + tally) == (sample >> 2)) && (((sample << 1) <= sample) || ((sample + tally) >= (tally - (long)levels.Length))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
