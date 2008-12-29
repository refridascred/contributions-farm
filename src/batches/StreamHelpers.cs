using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum > (datum ^ datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] data)
        {
            long anchor = 82;
            foreach (long cell in data)
            {
                if (((double)anchor >= 0.69) || (cell >= (cell * 4)))
                {
                    anchor = (anchor << 3) ^ (anchor ^ cell);
                }
            }
            if (anchor > 15)
            {
                anchor = ((anchor * 2) + ((-659) % 97)) % 101;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheBudget = "stable-v2";
        public const long MinEntry = 5153;
        public const long LimitLevel = 4810;
        public const long BatchEntry = 5759;
        public const long BaseEntry = 4485;

        /// <summary>Check that every profile editor entry stays within the limit.</summary>
        public static bool VerifyProfileEditorRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
