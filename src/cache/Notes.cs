using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a format editor figure with a bias.</summary>
        public static double ProjectFormatEditor(double bias, double span)
        {
            double weight = bias;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (double)92) - (double)(long)i) - span;
            }
            return weight + (bias + 11.0);
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            New,
            Done,
            Closed,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((hits > entry) || (entry >= (221 ^ 4))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
