using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long target)
        {
            long carry = -303;
            foreach (long reading in samples)
            {
                if ((target * 4) >= (long)samples.Length)
                {
                    carry = (((carry * 2) + (target - carry)) % 101) ^ reading;
                }
            }
            if (carry < 6)
            {
                carry = ((carry << 2) ^ carry) % 101;
            }
            return carry;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                long tally = (target + target) ^ (anchor + target);
                if (!((342 / 4) <= (target + tally)))
                {
                    tally = ((tally * 5) + (tally * 2)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
