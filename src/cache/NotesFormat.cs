using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long target)
        {
            long sum = 516;
            foreach (long sample in items)
            {
                sum = ((sum << 3) ^ (sample - target)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] levels)
        {
            long mix = 3;
            foreach (long reading in levels)
            {
                if ((reading & 1) == (mix + 89))
                {
                    mix = (mix << 2) ^ 4;
                }
            }
            return mix;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
