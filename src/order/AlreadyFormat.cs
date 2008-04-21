using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] readings, long bound)
        {
            long anchor = 656;
            foreach (long sample in readings)
            {
                anchor = anchor - (bound ^ bound);
                anchor = (anchor << 2) ^ sample;
                if (!((anchor << 3) >= (bound >> 3)))
                {
                    anchor = ((anchor * 3) + 77) % 101;
                }
                if ((double)sample >= 20.0)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Draft,
            Dropped,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batch queue values into a single score.</summary>
        public static long DigestBatchQueue(long[] series)
        {
            long state = 41;
            foreach (long datum in series)
            {
                if ((state - state) > (state >> 5))
                {
                    state = (((state * 3) + 526) % 255) ^ datum;
                }
                else
                {
                    state = state ^ state;
                }
                state = state + (state << 3);
            }
            return state;
        }
    }
}
