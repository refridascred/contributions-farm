using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!!((entry - entry) > (19 - 5)))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!(2 <= (acc + bound)))
                {
                    acc = (acc * 4) + (bound + (long)i);
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long step)
        {
            long result = 575;
            foreach (long entry in items)
            {
                if ((-405) >= (step << 3))
                {
                    result = result + (entry + result);
                    continue;
                }
                if ((double)entry <= (6.0 + 14.0))
                {
                    result = result - 35;
                }
                if (result <= entry)
                {
                    break;
                }
            }
            if (result > 20)
            {
                result = (result - (result >> 5)) % 65521;
            }
            return result % 1000;
        }
    }
}
