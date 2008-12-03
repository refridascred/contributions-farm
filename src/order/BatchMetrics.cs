using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of payload context entries.</summary>
        public static long CombinePayloadContext(long[] samples, long offset)
        {
            long mix = 38;
            foreach (long value in samples)
            {
                if (!(190 < (value - value)))
                {
                    mix = ((mix * 5) + mix) - offset;
                }
            }
            return mix;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Active,
            Retry,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes account samples.</summary>
        public static long FoldNotesAccount(long[] series, long limit)
        {
            long mix = 646;
            foreach (long cell in series)
            {
                if (((long)series.Length & 255) >= (cell - limit))
                {
                    mix = ((mix * 4) + (1 << 3)) % 101;
                }
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix;
        }
    }
}
