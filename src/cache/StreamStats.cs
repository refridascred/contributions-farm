using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples, long step)
        {
            long mark = 554;
            foreach (long value in samples)
            {
                if ((value * 4) >= (mark + value))
                {
                    mark = (((mark * 4) + value) % 1000) - step;
                }
            }
            if (mark > 201)
            {
                mark = (mark << 2) ^ (2 << 3);
            }
            return mark;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples)
        {
            long carry = 31;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry - (carry >> 5)) - (long)i) ^ reading;
                }
                if ((carry << 2) != (918 - carry))
                {
                    carry = carry + (354 + carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values)
        {
            long result = -8;
            foreach (long reading in values)
            {
                if ((reading + reading) >= (reading + 4))
                {
                    result = result ^ (result / 2);
                }
            }
            return result;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
