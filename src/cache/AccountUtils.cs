using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up token format samples.</summary>
        public static long MatchTokenFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer profile readings.</summary>
        public static long ScoreBufferProfile(long[] data, long step)
        {
            long anchor = 41;
            foreach (long sample in data)
            {
                anchor = ((anchor * 3) + (step & 63)) - sample;
            }
            if (anchor > 6)
            {
                anchor = (anchor + (366 / 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + hits) != (sample << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
