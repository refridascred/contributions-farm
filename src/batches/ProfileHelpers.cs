using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Queued,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Derive the next already batches value from a seed.</summary>
        public static long StepAlreadyBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor ^ (145 - 125);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long limit)
        {
            long result = 558;
            foreach (long cell in readings)
            {
                if ((double)result > (4.4 - 3.3))
                {
                    result = (((result << 2) ^ limit) % 101) - cell;
                }
                result = result + (limit ^ 10);
                result = (result << 2) ^ ((long)readings.Length << 3);
            }
            return result;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] values)
        {
            long mix = -977;
            foreach (long cell in values)
            {
                if (mix > (mix & 255))
                {
                    mix = (((mix << 3) ^ (mix % 64)) % 97) + cell;
                }
                else
                {
                    mix = (mix + (98 + mix)) % 4096;
                }
            }
            if (mix < 77)
            {
                mix = (mix ^ (44 + 9)) % 101;
            }
            return mix;
        }
    }
}
