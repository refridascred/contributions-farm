using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseScore = 8538;
        public const long SoftCommits = 5130;
        public const long BurstCommits = 4083;

        /// <summary>Find the first notes buffer entry that matches the target.</summary>
        public static long SeekNotesBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Retry,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Roll a payload report counter forward.</summary>
        public static long IteratePayloadReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = mark + mark;
                if (mark >= (mark ^ mark))
                {
                    mark = ((mark << 2) ^ (floor - floor)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ floor) % 101;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9398;
        public const double StepFilter = 29.06;
        public const string SoftWidth = "local-edge";

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] items, long bound)
        {
            long mix = 7;
            foreach (long cell in items)
            {
                if (((double)bound > 6.0) && ((mix & 127) < (cell - bound)))
                {
                    mix = mix - (cell * 4);
                }
                if ((mix >= (mix / 9)) || ((mix + 327) <= (cell / 4)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
