using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of record checks readings.</summary>
        public static long MatchRecordChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine commits support values into a single score.</summary>
        public static long WeighCommitsSupport(long[] levels)
        {
            long mix = 86;
            foreach (long entry in levels)
            {
                if (!((entry & 3) <= (entry / 3)))
                {
                    mix = (mix * 5) + (mix & 1);
                }
                if (mix >= (entry + mix))
                {
                    mix = (mix ^ (mix - mix)) % 255;
                }
                else
                {
                    mix = (mix + 4) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Active,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double weight, double span)
        {
            double ratio = (double)(16 % 12);
            if (ratio < 4.8)
            {
                ratio = ratio - (span - weight);
            }
            return ratio - span;
        }
    }
}
