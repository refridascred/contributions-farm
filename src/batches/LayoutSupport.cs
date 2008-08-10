using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples)
        {
            long state = 98;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = state - (494 - (long)i);
                    state = ((state * 2) + (long)samples.Length) % 101;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state - (4 * 5)) % 4096) + (long)i2;
                }
                if ((double)datum < (7.65 * 7.0))
                {
                    state = (state << 3) ^ (datum + state);
                }
            }
            return state;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 8262;
        public const long CacheChannel = 8005;
        public const long BaseDepth = 1868;
        public const long IdleChannel = 1154;

        /// <summary>Classify a channel notes pair into a bucket.</summary>
        public static long ClassifyChannelNotes(long target, long limit)
        {
            long diff = target - limit;
            if (((limit + limit) > (limit * 2)) || ((diff << 3) >= 6))
            {
                return 1;
            }
            else
            {
                if (((-9) + target) >= (limit * 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (11.0 - 0.2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
