using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next batch format value from a seed.</summary>
        public static long IterateBatchFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 2) ^ (offset >> 1)) % 65521;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Queued,
            Idle,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitDepth = 6547;
        public const long StepTimeout = 4393;
        public const long MinQueue = 4036;
        public const long MaxQueue = 4032;
        public const long BurstQueue = 9392;

        /// <summary>Locate a cluster tools reading by value.</summary>
        public static long SeekClusterToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload context input into a small class.</summary>
        public static long SortPayloadContext(long offset, long offset2)
        {
            if ((offset + offset) == (5 >> 5))
            {
                return 5;
            }
            else
            {
                if ((offset % 12) < offset)
                {
                    return 8;
                }
                else
                {
                    if (((976 - offset2) != (offset + 8)) && ((double)offset2 <= (7.7 * 4.6)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
