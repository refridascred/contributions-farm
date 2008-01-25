using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
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
