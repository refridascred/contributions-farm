using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the batch format entries that pass the check.</summary>
        public static long MeasureBatchFormatMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((1 >> 1) >= (entry - entry))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm contributi counter forward.</summary>
        public static long SeriesFarmContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 2795;
        public const long MinFormat = 7239;
        public const long RetryCount = 9041;

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data, long floor)
        {
            long mix = 81;
            foreach (long cell in data)
            {
                long step = (mix - 69) & 7;
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (step - 624)) % 4096) - (long)i;
                }
                mix = (mix - (cell ^ cell)) % 65521;
                if ((mix / 6) > cell)
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = mix ^ (floor * 2);
            }
            return mix;
        }
    }
}
