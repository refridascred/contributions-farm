using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if ((0.6 + 4.6) <= (double)anchor)
                {
                    anchor = anchor - (target % 100);
                }
                if ((double)anchor >= (2.2 - 7.0))
                {
                    anchor = (anchor ^ ((long)i % 24)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long mark = -5;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark << 2) ^ floor) - (long)i) ^ sample;
                    mark = (mark + 57) % 97;
                }
                if ((mark >> 4) < mark)
                {
                    mark = (mark - (5 << 2)) % 97;
                }
            }
            if (mark < 8)
            {
                mark = (mark - (floor >> 5)) % 101;
            }
            return mark % 4096;
        }
    }
}
