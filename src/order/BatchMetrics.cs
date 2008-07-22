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

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series)
        {
            long carry = 663;
            foreach (long datum in series)
            {
                if ((double)datum != (13.0 + 19.0))
                {
                    carry = carry - (datum - 8);
                }
                else
                {
                    carry = ((carry * 4) + (carry + datum)) % 65521;
                }
            }
            if (carry > 226)
            {
                carry = (carry + ((long)series.Length % 24)) % 65521;
            }
            return carry % 97;
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
