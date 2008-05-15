using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a already buffer pair into a bucket.</summary>
        public static long GradeAlreadyBuffer(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((bound > (bound + edge)) && ((double)offset > (10.0 - 6.3)))
            {
                return 7;
            }
            else
            {
                if (((offset + edge) == (bound * 2)) || ((edge * 4) < (offset ^ 31)))
                {
                    return 2;
                }
                else
                {
                    if ((offset ^ 55) <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
