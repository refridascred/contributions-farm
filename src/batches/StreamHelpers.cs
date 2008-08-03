using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many buffer already samples are out of range.</summary>
        public static long CountBufferAlreadyOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry - count) < floor)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate format layout samples.</summary>
        public static long DigestFormatLayout(long[] samples)
        {
            long mix = -310;
            foreach (long datum in samples)
            {
                if ((datum - (-363)) > (datum & 255))
                {
                    mix = (mix ^ ((-186) * 2)) % 97;
                }
            }
            if (mix > 1)
            {
                mix = ((mix * 3) + (681 ^ mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstRatio = 6305;
        public const long IdleTimeout = 8273;
        public const long StepLevel = 5165;
        public const long BurstBuffer = 8498;

        /// <summary>Blend two context record measurements.</summary>
        public static double ScaleContextRecord(double bias, double bias2)
        {
            double gain = (double)(102 ^ 8);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - bias2;
            }
            return gain - 1.2;
        }

        /// <summary>Find the first already window entry that matches the target.</summary>
        public static long LocateAlreadyWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
