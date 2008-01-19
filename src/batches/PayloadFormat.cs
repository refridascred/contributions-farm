using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSpan = 2699;
        public const long BatchNotes = 9754;
        public const string WindowNotes = "local-1";
        public const long StepInterval = 9175;
        public const long MaxNotes = 9260;

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] levels)
        {
            long mix = 291;
            foreach (long cell in levels)
            {
                mix = ((mix << 3) ^ cell) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Closed,
            New,
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
