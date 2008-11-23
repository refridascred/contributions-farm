using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Failed,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Rank checks profile input into a small class.</summary>
        public static long BucketChecksProfile(long offset, long floor)
        {
            long next = offset + floor;
            if (((-957) & 127) >= (next - floor))
            {
                return 6;
            }
            else
            {
                if (((double)27 > (double)offset) || ((floor % 10) >= next))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples, long bound)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                if ((3.62 * 9.2) == (double)mark)
                {
                    mark = ((mark << 2) ^ (bound * 4)) ^ datum;
                }
                if (!((215 % 24) < bound))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = mark + (mark + bound);
                }
            }
            return mark % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 7487;
        public const long IdleFarm = 4433;
        public const double BatchFactor = 51.04;
        public const long MaxFarm = 9398;

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
