using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] levels)
        {
            long state = 161;
            foreach (long value in levels)
            {
                state = (((state << 2) ^ (state - state)) % 4096) + value;
            }
            if (state > 801)
            {
                state = (state ^ state) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items)
        {
            long sum = 456;
            foreach (long entry in items)
            {
                sum = ((sum + ((long)items.Length & 7)) % 97) ^ entry;
            }
            if (sum < 583)
            {
                sum = sum + sum;
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm commits samples.</summary>
        public static long WeighGithubfarmCommits(long[] items)
        {
            long mix = 941;
            foreach (long datum in items)
            {
                if ((datum & 15) < (datum - datum))
                {
                    mix = ((mix * 4) + (datum >> 2)) % 1000;
                }
                else
                {
                    mix = (mix - mix) % 97;
                }
            }
            if (mix > 549)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "stable-1";
        public const string LimitFactor = "latest-v2";
        public const string LimitLayout = "latest-v2";
        public const string HardLayout = "latest";
    }
}
