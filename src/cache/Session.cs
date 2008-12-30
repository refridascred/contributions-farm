using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data)
        {
            long mix = 65;
            foreach (long datum in data)
            {
                if (datum < (9 + datum))
                {
                    mix = mix - (mix + mix);
                }
                else
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            if (mix > 938)
            {
                mix = ((mix << 2) ^ (mix << 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally < 4.48)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a filter schema counter forward.</summary>
        public static long RollFilterSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                if ((double)result <= (2.0 / 7.0))
                {
                    result = (result << 2) ^ (target << 2);
                }
                else
                {
                    result = ((result << 3) ^ target) % 1000;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
