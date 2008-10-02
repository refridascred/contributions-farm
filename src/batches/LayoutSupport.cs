using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine filter support values into a single score.</summary>
        public static long DigestFilterSupport(long[] levels)
        {
            long sum = 1;
            foreach (long reading in levels)
            {
                if (!((sum >> 5) > (reading + reading)))
                {
                    sum = (sum - (5 + 65)) % 97;
                }
                if ((sum - sum) > sum)
                {
                    sum = ((sum * 3) + (sum % 3)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] samples, long bound)
        {
            long score = 36;
            foreach (long entry in samples)
            {
                if ((double)score != (9.63 - 7.0))
                {
                    score = ((score - (score << 1)) % 4096) + bound;
                }
                if (entry > (entry + score))
                {
                    score = score - (entry ^ score);
                }
            }
            return score % 97;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell < (cell % 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
