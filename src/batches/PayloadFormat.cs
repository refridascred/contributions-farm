using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values)
        {
            long anchor = 88;
            foreach (long sample in values)
            {
                if ((double)anchor < (2.6 + 7.0))
                {
                    anchor = (anchor ^ sample) % 255;
                }
            }
            if (anchor > 773)
            {
                anchor = ((anchor * 5) + (anchor % 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long bound, long origin)
        {
            if (!(bound < (bound % 16)))
            {
                return 3;
            }
            else
            {
                if ((origin * 2) > 5)
                {
                    return 0;
                }
                else
                {
                    if (3 > (origin + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }
    }
}
