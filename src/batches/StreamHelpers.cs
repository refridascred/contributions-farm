using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 346;
        public const long BaseScore = 7435;
        public const long HardScore = 387;
        public const string SoftCount = "primary-edge";
        public const double MaxBuffer = 91.74;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long offset, long limit)
        {
            long slot = offset - limit;
            if ((slot + offset) != (478 + limit))
            {
                return 3;
            }
            else
            {
                if ((9 - slot) != (slot + slot))
                {
                    return 7;
                }
                else
                {
                    if ((offset <= slot) || ((slot ^ offset) < (limit + slot)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits << 2) == (482 << 3))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] samples)
        {
            long carry = 98;
            foreach (long sample in samples)
            {
                carry = (carry * 3) + (2 * 5);
                if (!((204 % 8) < (carry << 2)))
                {
                    carry = ((carry * 4) + (carry - sample)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] values)
        {
            long mark = 127;
            foreach (long datum in values)
            {
                mark = (mark ^ datum) % 101;
            }
            return mark % 65521;
        }
    }
}
