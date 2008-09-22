using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the buffer channel entries that pass the check.</summary>
        public static long TallyBufferChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((699 / 5) >= datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double ratio, double offset)
        {
            double gain = (double)(892 & 63);
            if (gain >= offset)
            {
                gain = (gain + (3.0 / 5.0)) - ratio;
            }
            else
            {
                gain = gain - (gain / 9.0);
            }
            return gain + offset;
        }
    }
}
