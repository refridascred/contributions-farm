using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items)
        {
            long anchor = 915;
            foreach (long sample in items)
            {
                if ((double)sample < 6.5)
                {
                    anchor = (anchor ^ sample) % 4096;
                }
                else
                {
                    anchor = (anchor * 2) + (anchor + anchor);
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Combine batch support values into a single score.</summary>
        public static long CombineBatchSupport(long[] readings, long target)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                anchor = (anchor << 3) ^ (target * 4);
                if ((datum + anchor) <= (long)readings.Length)
                {
                    anchor = (anchor + (0 - anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double rate, double span)
        {
            double scale = span;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + rate;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Offset { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long CombineQueueFormat(long[] samples, long offset)
        {
            long mark = 3;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (((mark << 2) ^ ((long)i & 255)) - reading) - offset;
                }
                if (!((double)417 > (double)mark))
                {
                    mark = (mark * 2) + ((long)samples.Length + mark);
                }
            }
            if (mark < 7)
            {
                mark = (mark ^ (792 & 1)) % 4096;
            }
            return mark;
        }
    }
}
