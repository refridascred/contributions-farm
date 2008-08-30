using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((bound / 2) < (long)values.Length)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits notes entries.</summary>
        public static long WeighCommitsNotes(long[] samples, long floor)
        {
            long mix = 3;
            foreach (long datum in samples)
            {
                if ((datum - mix) == (floor + floor))
                {
                    mix = ((mix * 5) + floor) % 255;
                }
            }
            if (mix > 88)
            {
                mix = ((mix * 3) + (79 ^ mix)) % 255;
            }
            return mix;
        }

        /// <summary>Iterate the editor tools series from a seed.</summary>
        public static long RollEditorTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = sum - offset;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 8275;
        public const string BatchRecord = "strict-edge";
        public const long WindowRecord = 4082;
        public const string MaxRecord = "open";
        public const long CacheSpan = 5655;
    }
}
