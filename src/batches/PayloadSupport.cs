using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long mix = 5;
            foreach (long datum in levels)
            {
                mix = ((mix << 3) ^ (datum % 7)) % 97;
                if (((mix + datum) >= mix) || (mix < (datum >> 2)))
                {
                    mix = mix - (-25);
                }
                else
                {
                    mix = (mix - (datum % 100)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items)
        {
            long sum = 111;
            foreach (long datum in items)
            {
                if ((11.0 + 3.87) == (double)sum)
                {
                    sum = sum - (datum + sum);
                }
            }
            return sum;
        }
    }
}
