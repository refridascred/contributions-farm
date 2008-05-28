using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Roll a payload batches counter forward.</summary>
        public static long DerivePayloadBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark * 3) + mark) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data, long limit)
        {
            long total = 785;
            foreach (long datum in data)
            {
                total = (((total << 2) ^ limit) % 65521) - datum;
                if ((total & 31) >= (limit >> 2))
                {
                    break;
                }
            }
            return total;
        }
    }
}
