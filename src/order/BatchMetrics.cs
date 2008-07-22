using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many stream graph samples are out of range.</summary>
        public static long MeasureStreamGraphGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits - (long)levels.Length) < item)
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long carry = 67;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry - (carry % 5)) % 101) - (long)i;
                }
                if ((carry * 4) > (sample - carry))
                {
                    carry = (carry + (carry / 6)) % 1000;
                }
                if ((sample <= (842 + sample)) || ((carry + carry) <= sample))
                {
                    carry = (carry * 4) + (sample & 7);
                }
                else
                {
                    carry = carry ^ (1 / 5);
                }
                if ((double)10 == (double)sample)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long seed)
        {
            long step = offset - seed;
            if ((offset - seed) > seed)
            {
                return 4;
            }
            else
            {
                if (!(step <= (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((step - step) > (step + 972))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.0 + 16.0) < (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
