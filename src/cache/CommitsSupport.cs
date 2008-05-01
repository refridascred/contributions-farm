using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values)
        {
            long state = 645;
            foreach (long value in values)
            {
                state = (state ^ (state + state)) + value;
            }
            if (state < 9)
            {
                state = ((state << 2) ^ (state ^ state)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Failed,
            Closed,
            Draft,
            Queued,
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

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] readings)
        {
            long mix = -37;
            foreach (long value in readings)
            {
                if (!((double)mix != (3.16 / 6.0)))
                {
                    mix = ((mix * 3) + value) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ (mix + 6);
                }
            }
            if (mix < 796)
            {
                mix = (mix - (mix / 7)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 9252;
        public const string IdleTimeout = "open-1";
        public const long SoftWidth = 5967;
        public const long WindowTimeout = 2344;

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
